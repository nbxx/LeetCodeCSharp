// Source : https://leetcode.com/problems/spiral-matrix/ 
// Author : codeyu 
// Date : Friday, November 11, 2016 11:56:46 PM 

/**********************************************************************************
*
* Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
* 
* 
* 
* For example,
* Given the following matrix:
* 
* 
* [
*  [ 1, 2, 3 ],
*  [ 4, 5, 6 ],
*  [ 7, 8, 9 ]
* ]
* 
* 
* You should return [1,2,3,6,9,8,7,4,5].
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
using System.Linq;
namespace Algorithms
{
    public class Solution054 
    {
        public static IList<int> SpiralOrder(int[,] matrix) 
        {
            IList<int> result = new List<int>();  
            if(matrix == null || matrix.GetLength(0)==0 || matrix.GetLength(1) == 0)  
                return result;  
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
        
            int left=0;
            int right=n-1;
            int top = 0;
            int bottom = m-1;  
            while(result.Count<m*n) 
            {  
                for(int j=left; j<=right; j++){
                    result.Add(matrix[top,j]);
                }
                top++;
        
                for(int i=top; i<=bottom; i++){
                    result.Add(matrix[i,right]);
                }
                right--;
        
                //prevent duplicate row
                if(bottom<top)
                    break;
        
                for(int j=right; j>=left; j--){
                    result.Add(matrix[bottom,j]);
                }
                bottom--;
        
                // prevent duplicate column
                if(right<left)
                    break;
        
                for(int i=bottom; i>=top; i--){
                    result.Add(matrix[i,left]);
                }
                left++; 
            }  
            return result;
        }
        IEnumerable<T> ArrayItems<T>(T[,] matrix, int colindex)
        {
            return matrix.Cast<T>().Skip(matrix.GetLength(1) * colindex).Take(matrix.GetLength(1));
        }
    }
}

