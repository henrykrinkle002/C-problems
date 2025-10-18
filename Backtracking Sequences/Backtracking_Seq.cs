sing System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'generateAngleBracketSequences' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts INTEGER n as parameter.
     */

    public static List<string> generateAngleBracketSequences(int n){
        
        var result = new List<string>();
        Backtrack(result, "", 0, 0, n);
        
        void Backtrack(List<string> result, string current, int open, int close, int n){
            
            if(current.Length == 2*n){
                result.Add(current);
                return;
            }
                
            if(open < n)
                Backtrack(result, current+"<", open+1, close, n);
            
            if(close < open)
                Backtrack(result, current+">", open, close+1, n);   
                
        }
        
        return result;
}
}