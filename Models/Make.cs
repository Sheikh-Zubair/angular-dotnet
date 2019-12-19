using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace angular_dotnet.Models
{
    public class Make
    {
        public Make(int id, string name)
        {
            Models = new Collection<Model>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}