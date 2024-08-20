using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LinkModels
{
    public class LinkCollectionWrapper<T> :LinkSourceBase
    {

        public List<T> Value { get; set; } = new List<T>();

        public LinkCollectionWrapper(List<T> value)
        {
            Value = value;
        }
        public LinkCollectionWrapper()
        {

        }

    }
}
