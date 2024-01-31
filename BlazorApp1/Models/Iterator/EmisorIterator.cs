
using System.Collections;

namespace BlazorApp1.Models.Iterator
{

    // Implementación de la interfaz IEnumerator
    public class EmisorIterator : IEnumerator
    {
        private List<Emisor> emisores;
        private int index = -1;

        public EmisorIterator(List<Emisor> emisores)
        {
            this.emisores = emisores;
        }

        public Emisor Current => emisores[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // Dispose resources, if any
        }

        public bool MoveNext()
        {
            index++;
            return index < emisores.Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
