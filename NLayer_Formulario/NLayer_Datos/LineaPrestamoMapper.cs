using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer_Entidades;
using Newtonsoft.Json;
using System.Collections.Specialized;


namespace NLayer_Datos
{
    public class ListaPrestamoMapper
    {
        private string _endpointPath = "/prestamotipo";

      
        private List<TipoPrestamo> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
        }

        private TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
    }
}
