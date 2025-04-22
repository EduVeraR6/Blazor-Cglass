using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using PruebaBlazor.Models;
using PruebaBlazor.Models.CLI.CliClient;
using PruebaBlazor.Models.CLI.CliClientParamVigencias;
using PruebaBlazor.Services;
using PruebaBlazor.Utils.Paginacion;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PruebaBlazor.Pages
{
    public partial class ClientParamVigencia : ComponentBase
    {
        private OperacionEstado estadoActual = OperacionEstado.Ninguna;



        private HashSet<CliClientesParamVigenciasPK> seleccionados = new();
        private List<CliClientesParamVigenciasDAO>? parametros;
        private List<CliClienteDAO> clientes = new();  
        private Page<CliClientesParamVigenciasDAO> cliClienteParamVigencia;
        private int paginaActual = 0;
        private int tamanioPagina = 5;

        private HashSet<long> editando = new HashSet<long>();


        protected override async Task OnInitializedAsync()
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            cliClienteParamVigencia = await PaginacionService.CargarPagina<CliClientesParamVigenciasDAO>("CliClientParamVigencia/1?", paginaActual, tamanioPagina);
            parametros = cliClienteParamVigencia?.Content ?? new List<CliClientesParamVigenciasDAO>();

            var responseClientes = await Http.GetAsync("CliClientes/1");
            if (responseClientes.IsSuccessStatusCode)
            {
                var clientesResult = await responseClientes.Content.ReadFromJsonAsync<Page<CliClienteDAO>>();
                clientes = clientesResult?.Content ?? new List<CliClienteDAO>();
            }
        }

        private async Task CargarPagina(int pagina)
        {
            paginaActual = pagina;
            await CargarDatos();
        }

        private async Task CambiarTamanioPagina(int nuevoTamanio)
        {
            tamanioPagina = nuevoTamanio;
            paginaActual = 0;
            await CargarDatos();
        }


        private string filtroTexto = string.Empty;

        private async Task HandleKeyDown(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                await BuscarParametros();
            }
        }

        private async Task BuscarParametros()
        {
            if (string.IsNullOrWhiteSpace(filtroTexto))
            {
                await OnInitializedAsync();
                return;
            }

            try
            {
                cliClienteParamVigencia = await PaginacionService.CargarPagina<CliClientesParamVigenciasDAO>(
                    $"CliClientParamVigencia/filtro/1?filtro={Uri.EscapeDataString(filtroTexto)}&",
                    paginaActual,
                    tamanioPagina);

                parametros = cliClienteParamVigencia?.Content ?? new List<CliClientesParamVigenciasDAO>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error buscando: {ex.Message}");
            }
        }


        private void SeleccionarRegistro(CliClientesParamVigenciasPK id, object? valor)
        {
            if (valor is bool isChecked)
            {
                if (isChecked)
                    seleccionados.Add(id);
                else
                    seleccionados.Remove(id);
            }
        }



        private async Task EliminarSeleccionados()
        {
            if (estadoActual != OperacionEstado.Ninguna)
            {
                ToastService.ShowWarning("Complete la operación actual antes de eliminar registros", 5);
                return;
            }

            if (seleccionados.Any())
            {
                var registrosAEliminar = parametros.Where(param => seleccionados.Contains(param.Id)).ToList();

                var registrosSave = registrosAEliminar.Select(registro => new CliClientesParamVigenciasSaveDAO
                {
                    Id = registro.Id,
                    Estado = "N",
                    UsuarioModificacion = 1,
                }).ToList();

                try
                {
                    var token = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
                    Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response = await Http.PutAsJsonAsync("https://localhost:5106/CliClientParamVigencia/varios", registrosSave);

                    if (response.IsSuccessStatusCode)
                    {
                        parametros.RemoveAll(param => seleccionados.Contains(param.Id));
                        seleccionados.Clear();
                        StateHasChanged();

                        if (parametros.Count == 0 && paginaActual > 0)
                        {
                            paginaActual--;
                            await CargarDatos();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error al eliminar los registros: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar los registros: {ex.Message}");
                }
            }
        }



        private void AgregarNuevoRegistro()
        {
            if (estadoActual != OperacionEstado.Ninguna)
            {
                ToastService.ShowWarning("Complete la operación actual antes de crear un nuevo registro", 5);
                return;
            }

            if (parametros.Any(p => p.Id.Codigo == 0))
            {
                ToastService.ShowWarning("Ya existe un registro en creación. Complete o cancele ese primero.", 5);
                return;
            }

            estadoActual = OperacionEstado.Creando;


            var nuevo = new CliClientesParamVigenciasDAO
            {
                Estado = "A",
                Observacion = "",
                FechaDesde = DateTime.Today,
                FechaHasta = DateTime.Today.AddMonths(1),
                ValorParametro = "",
                Id = new CliClientesParamVigenciasPK
                {
                    CliClientCodigo = 0,
                    CliClientAgeLicencCodigo = clientes.FirstOrDefault()?.Id?.AgeLicencCodigo ?? 0,
                    CLIParGeCodigo = 0,
                    Codigo = 0
                },
                Cliente = new CliClienteDAO
                {
                    Id = new CliClientesPK
                    {
                        Codigo = clientes.FirstOrDefault()?.Id?.Codigo ?? 0,
                        AgeLicencCodigo = clientes.FirstOrDefault()?.Id?.AgeLicencCodigo ?? 0
                    },
                    Nombres = clientes.FirstOrDefault()?.Nombres ?? ""
                }
            };

            parametros.Insert(0, nuevo);
        }


        private void EditarRegistro(CliClientesParamVigenciasDAO registro)
        {
            if (estadoActual != OperacionEstado.Ninguna)
            {
                ToastService.ShowWarning("Complete la operación actual antes de editar un registro", 5);
                return;
            }

            estadoActual = OperacionEstado.Editando;
            editando.Add(registro.Id.Codigo);
        }

        private void CancelarRegistro(CliClientesParamVigenciasDAO registro)
        {
            if (registro.Id.Codigo == 0)
            {
                parametros.Remove(registro);
                estadoActual = OperacionEstado.Ninguna;
            }
            else
            {
                editando.Remove(registro.Id.Codigo);
                estadoActual = OperacionEstado.Ninguna;
            }
        }

        private void ClienteSeleccionadoNuevo(CliClientesParamVigenciasDAO item, ChangeEventArgs e)
        {
            if (int.TryParse(e.Value?.ToString(), out int codigoCliente))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id.Codigo == codigoCliente);
                if (cliente != null)
                {
                    item.Cliente = cliente;

                    item.Id.CliClientCodigo = (int)cliente.Id.Codigo;  
                    item.Id.CliClientAgeLicencCodigo = cliente.Id.AgeLicencCodigo;  

                    item.Id.CLIParGeCodigo = 1; 
                }
            }
        }

        private async Task ConfirmarRegistro(CliClientesParamVigenciasDAO registro)
        {
            var saveModel = new CliClientesParamVigenciasSaveDAO
            {
                Id = registro.Id,
                Observacion = registro.Observacion,
                FechaDesde = registro.FechaDesde,
                FechaHasta = registro.FechaHasta,
                Estado = registro.Estado,
                ValorParametro = registro.ValorParametro,
                UsuarioIngreso = registro.Id.Codigo == 0 ? 1 : 0,
                UsuarioModificacion = registro.Id.Codigo == 0 ? 0 : 1,
            };

            try
            {
                HttpResponseMessage response;
                bool esNuevoRegistro = registro.Id.Codigo == 0;

                response = esNuevoRegistro
                    ? await Http.PostAsJsonAsync("CliClientParamVigencia", saveModel)
                    : await Http.PutAsJsonAsync("CliClientParamVigencia", saveModel);

                var content = await response.Content.ReadAsStringAsync();
              
                if (response.IsSuccessStatusCode)
                {
                    await OnInitializedAsync();
                    editando.Remove(registro.Id.Codigo);
                    estadoActual = OperacionEstado.Ninguna;


                    if (esNuevoRegistro)
                    {
                        ToastService.ShowSuccess("Registro creado con éxito", 5);
                    }
                    else
                    {
                        ToastService.ShowSuccess($"{content}", 5);
                    }
                }
                else
                {
                    string tipoOperacion = esNuevoRegistro ? "Registrar" : "Actualizar";
                    Console.WriteLine($"Error al {tipoOperacion}: {response.StatusCode}");
                    ToastService.ShowError($"Error al {tipoOperacion}: {content}", 5);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error guardando registro: {ex.Message}");
            }
        }


        private async void EliminarRegistro(CliClientesParamVigenciasDAO registro)
        {


            if (estadoActual != OperacionEstado.Ninguna)
            {
                ToastService.ShowWarning("Complete la operación actual antes de eliminar un registro", 5);
                return;
            }

            registro.Estado = "N";
            await ConfirmarRegistro(registro);
            StateHasChanged();
        }


        private async void AlternarEstado(CliClientesParamVigenciasDAO item)
        {
            item.Estado = item.Estado == "A" ? "I" : "A";
            await ConfirmarRegistro(item);
        }

    }
}
