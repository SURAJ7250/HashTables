namespace NonLinearDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                MyMapNode<string, int> hash = new MyMapNode<string, int>(6);
                string words = ("to be or not to be");
                string[] arr = words.Split(' ');
                Console.WriteLine("Select Programs\n 1.Frewuency of words");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LinkedList<string> checkForDuplication = new LinkedList<string>();
                        foreach (string element in arr)
                        {
                            int count = 0;
                            foreach (string match in arr)
                            {
                                if (element == match)
                                {
                                    count++;
                                    if (checkForDuplication.Contains(element))
                                    {
                                        break;
                                    }
                                }
                            }
                            if (checkForDuplication.Contains(element))
                            {
                                continue;
                            }
                            checkForDuplication.AddLast(element);
                            hash.Add(element, count);//to,2
                        }
                        Console.WriteLine("Frequency of the world");
                        hash.Display();
                        break;
                }
            }
        }
    }
}
                
        
    
