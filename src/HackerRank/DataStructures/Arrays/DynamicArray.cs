/*
https://www.hackerrank.com/challenges/dynamic-array/problem

Create a list, , of  empty sequences, where each sequence is indexed from  to . The elements within each of the  sequences also use -indexing.
Create an integer, , and initialize it to .
The  types of queries that can be performed on your list of sequences () are described below:
Query: 1 x y
Find the sequence, , at index  in .
Append integer  to sequence .
Query: 2 x y
Find the sequence, , at index  in .
Find the value of element  in  (where  is the size of ) and assign it to .
Print the new value of  on a new line
Task
Given , , and  queries, execute each query.

Note:  is the bitwise XOR operation, which corresponds to the ^ operator in most languages. Learn more about it on Wikipedia.

Input Format

The first line contains two space-separated integers,  (the number of sequences) and  (the number of queries), respectively.
Each of the  subsequent lines contains a query in the format defined above.

Constraints

It is guaranteed that query type  will never query an empty sequence or index.
Output Format

For each type  query, print the updated value of  on a new line.

Sample Input

2 5
1 0 5
1 1 7
1 0 3
2 1 0
2 1 1
Sample Output

7
3
Explanation

Initial Values:


 = [ ]
 = [ ]

Query 0: Append  to sequence .

 = [5]
 = [ ]

Query 1: Append  to sequence .
 = [5]
 = [7]

Query 2: Append  to sequence .

 = [5, 3]
 = [7]

Query 3: Assign the value at index  of sequence  to , print .

 = [5, 3]
 = [7]

7
Query 4: Assign the value at index  of sequence  to , print .

 = [5, 3]
 = [7]

3
*/

using System.Collections.Generic;

class DynamicArray
{
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> computation = new List<List<int>>();
        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            computation.Add(new List<int>());
        }

        int lastAnswer = 0;
        for (int i = 0; i < queries.Count; i++)
        {
            List<int> q = queries[i];

            if (q[0] == 1)
            {
                computation[(q[1] ^ lastAnswer) % n].Add(q[2]);
            }
            else
            {
                List<int> seq = computation[(q[1] ^ lastAnswer) % n];
                lastAnswer = seq[q[2] % seq.Count];
                result.Add(lastAnswer);
            }
        }

        return result;
    }
}
