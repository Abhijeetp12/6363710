using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public static class SearchAlgorithms
    {
        public static int LinearSearch(Product[] products, string targetProduct)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName.Equals(targetProduct, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch(Product[] sortedProducts, string targetProduct)
        {
            int left = 0;
            int right = sortedProducts.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int get_Product = string.Compare(sortedProducts[mid].ProductName, targetProduct, true);

                if (get_Product == 0) return mid;

                else if (get_Product < 0) left = mid + 1;

                else right = mid - 1;
            }
            return -1;
        }
      }
    }
