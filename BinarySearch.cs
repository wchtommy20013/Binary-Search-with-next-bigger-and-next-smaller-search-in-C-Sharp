using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch {
    class BinarySearch {
        /**
         * This method is used to find exact position of num 
         * in arr with binary search method.
         * @param num       The number to be found.
         * @param arr       A pre-sorted non-repeating ascending array to be searched.
         * @param arrlen    This is the size of arr.
         * @return int      This returns position of num in arr. (-1 for not found)
         */
        public static int Exact(int num, int[] arr, int arrlen) {
            int high = arrlen - 1;
            int low = 0;
            while (low <= high) {
                int mid = (high + low) / 2;
                if (num == arr[mid]) return mid;
                else if (arr[mid] < num) low = mid + 1;
                else if (arr[mid] > num) high = mid - 1;
            }
            return -1;
        }

        /**
         * This method is used to find position of next bigger integer 
         * compare to num in arr with binary search method.
         * @param num       The number to be found.
         * @param arr       A pre-sorted non-repeating ascending array to be searched.
         * @param arrlen    This is the size of arr.
         * @return int      This returns position of num in arr. (-1 for not found)
         */
        public static int NextBigger(int num, int[] arr, int arrlen) {
            int high = arrlen - 1;
            int low = 0;
            while (low <= high) {
                int mid = (high + low) / 2;
                if (num == arr[mid]) return mid + 1;
                else if (arr[mid] < num) low = mid + 1;
                else if (arr[mid] > num) high = mid - 1;
            }

            if (high < 0) return 0;
            else if (low > arrlen - 1) return -1;
            else return low;
        }

        /**
         * This method is used to find position of next smaller integer 
         * compare to num in arr with binary search method.
         * @param num       The number to be found.
         * @param arr       A pre-sorted non-repeating ascending array to be searched.
         * @param arrlen    This is the size of arr.
         * @return int      This returns position of num in arr. (-1 for not found)
         */
        public static int NextSmaller(int num, int[] arr, int arrlen) {
            int high = arrlen - 1;
            int low = 0;
            while (low <= high) {
                int mid = (high + low) / 2;
                if (num == arr[mid]) return mid - 1;
                else if (arr[mid] < num) low = mid + 1;
                else if (arr[mid] > num) high = mid - 1;
            }

            if (high < 0) return -1;
            else if (low > arrlen - 1) return arrlen - 1;
            else return high;
        }
    }
}
