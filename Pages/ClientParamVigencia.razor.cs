/*using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using PruebaBlazor.Models.CLI.CliClient;
using PruebaBlazor.Models.CLI.CliClientParamVigencias;
using PruebaBlazor.Utils.Paginacion;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PruebaBlazor.Pages
{
    public partial class ClientParamVigencia: ComponentBase
    {
        [Inject] protected HttpClient Http { get; set; }
        [Inject] protected IJSRuntime JSRuntime { get; set; }

        private HashSet<CliClientesParamVigenciasPK> seleccionados = new();
        private List<CliClientesParamVigenciasDAO>? parametros;
        private List<CliClienteDAO> clientes = new();  // Clientes traídos desde API

        private HashSet<long> editando = new HashSet<long>();

        protected override async Task OnInitializedAsync()
        {
            var token = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            try
            {
                // Cargar parámetros
                var response = await Http.GetAsync("CliClientParamVigencia/1");
                if (response.IsSuccessStatusCode)
                {
                    var pageResult = await response.Content.ReadFromJsonAsync<Page<CliClientesParamVigenciasDAO>>();
                    parametros = pageResult?.Content ?? new List<CliClientesParamVigenciasDAO>();
                }

                // Cargar clientes
                var responseClientes = await Http.GetAsync("CliClientes/1"); // Ajusta al endpoint real
                if (responseClientes.IsSuccessStatusCode)
                {
                    var clientesResult = await responseClientes.Content.ReadFromJsonAsync<Page<CliClienteDAO>>();
                    clientes = clientesResult?.Content ?? new List<CliClienteDAO>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cargando datos: {ex.Message}");
            }
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
                await OnInitializedAsync(); // Recarga la lista completa si está vacío
                return;
            }

            try
            {
                var token = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await Http.GetAsync($"CliClientParamVigencia/filtro/1?filtro={Uri.EscapeDataString(filtroTexto)}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<Page<CliClientesParamVigenciasDAO>>();
                    parametros = result?.Content ?? new List<CliClientesParamVigenciasDAO>();
                }
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
            if (seleccionados.Any())
            {
                // Primero, modificar el estado de los registros seleccionados
                var registrosAEliminar = parametros.Where(param => seleccionados.Contains(param.Id)).ToList();

                // Crear una lista de objetos tipo save para enviar al backend
                var registrosSave = registrosAEliminar.Select(registro => new CliClientesParamVigenciasSaveDAO
                {
                    Id = registro.Id,
                    Estado = "N",  // Cambiar el estado a "N"
                    UsuarioModificacion = 1,  // Establecer UsuarioModificacion a 1
                }).ToList();

                try
                {
                    var token = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "jwt_token");
                    Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    // Enviar los registros modificados al servidor para eliminar en lote
                    var response = await Http.PutAsJsonAsync("https://localhost:5106/CliClientParamVigencia/varios", registrosSave);

                    if (response.IsSuccessStatusCode)
                    {
                        // Si la eliminación fue exitosa, actualizamos la lista de parámetros
                        parametros.RemoveAll(param => seleccionados.Contains(param.Id));
                        seleccionados.Clear(); // Limpiar la lista de seleccionados
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
            editando.Add(registro.Id.Codigo);
        }

        private void CancelarRegistro(CliClientesParamVigenciasDAO registro)
        {
            if (registro.Id.Codigo == 0)
            {
                parametros.Remove(registro); // Era nuevo
            }
            editando.Remove(registro.Id.Codigo);
        }

        private void ClienteSeleccionadoNuevo(CliClientesParamVigenciasDAO item, ChangeEventArgs e)
        {
            if (int.TryParse(e.Value?.ToString(), out int codigoCliente))
            {
                var cliente = clientes.FirstOrDefault(c => c.Id.Codigo == codigoCliente);
                if (cliente != null)
                {
                    item.Cliente = cliente;

                    // Actualizar la PK del registro con datos del cliente seleccionado
                    item.Id.CliClientCodigo = (int)cliente.Id.Codigo;  // Asignar código del cliente
                    item.Id.CliClientAgeLicencCodigo = cliente.Id.AgeLicencCodigo;  // Asignar AgeLicencCodigo del cliente

                    // Establecer el valor de CLIParGeCodigo, puedes dejarlo en 0 si no tiene un valor específico.
                    item.Id.CLIParGeCodigo = 1; // O cualquier valor si lo necesitas.
                }
            }
        }

        private async void ConfirmarRegistro(CliClientesParamVigenciasDAO registro)
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
                if (registro.Id.Codigo == 0)
                {
                    response = await Http.PostAsJsonAsync("CliClientParamVigencia", saveModel);
                }
                else
                {
                    response = await Http.PutAsJsonAsync($"CliClientParamVigencia", saveModel);
                }

                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response content: " + content); // Imprime la respuesta como texto para depuración

                if (response.IsSuccessStatusCode)
                {
                    await OnInitializedAsync();
                    editando.Remove(registro.Id.Codigo);
                }
                else
                {
                    Console.WriteLine($"Error al guardar: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error guardando registro: {ex.Message}");
            }
        }


        private async void EliminarRegistro(CliClientesParamVigenciasDAO registro)
        {
            registro.Estado = "N";
            ConfirmarRegistro(registro);
        }

        private void AlternarEstado(CliClientesParamVigenciasDAO item)
        {
            item.Estado = item.Estado == "A" ? "I" : "A";
            ConfirmarRegistro(item);
        }




    }
}
*/
