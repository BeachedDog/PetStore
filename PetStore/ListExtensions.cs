using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public static class ListExtensions
    {
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }

        public static List<T> GatherProductsByNameIntoList<T>(this List<T> list, string name) where T : Product
        
            {
                return list.Where(x => x.Name == name).ToList();
            }
            
        }
    }

