
/*
Lecture 73: Create a Dynamic Link
Library and Reference it
*/

namespace CompServices
{
    public class Caluclator
    {
        public dynamic Add(dynamic x, dynamic y)
        {
            return x + y;
        }

        public dynamic Divide(dynamic x, dynamic y)
        {
            return y != 0 ? x / y : "Error: Divide by Zero";
        }
    }
}
