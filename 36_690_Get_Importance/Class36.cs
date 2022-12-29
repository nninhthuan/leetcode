using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_690_Get_Importance
{
    class Solution
    {
        // Definition for Employee.
        public class Employee {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }

        public static int GetImportance(IList<Employee> employees, int id)
        {
            int total = 0;
            Queue<int> q = new Queue<int>();
            q.Enqueue(id);
            bool[] visited = new bool[2001];
            while (q.Count > 0)
            {
                int remId = q.Dequeue();
                if (!visited[remId])
                {
                    visited[remId] = true;
                    foreach (Employee emp in employees)
                    {
                        if (emp.id == remId)
                        {
                            total += emp.importance;
                            foreach (int so in emp.subordinates)
                            {
                                q.Enqueue(so);
                            }
                            break;
                        }
                    }
                }
            }
            return total;
        }

        public static void Main(string[] args)
        {
            IList<Employee> employees = new List<Employee>();
            int id = 1;
            int result = GetImportance(employees, id);
        }
    }
}
