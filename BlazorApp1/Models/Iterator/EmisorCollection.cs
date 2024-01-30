using System.Collections;

namespace BlazorApp1.Models.Iterator
{
    public class EmisorCollection : IEnumerable<Emisor>
    {
        private List<Emisor> emisores = new List<Emisor>();

        public void AddEmisor(Emisor emisor)
        {
            emisores.Add(emisor);
        }


        public IEnumerator<Emisor> GetEnumerator()
        {
            return emisores.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EmisorIterator(emisores);
        }
    }
}
