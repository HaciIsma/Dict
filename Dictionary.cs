using System;

namespace ConsoleApp3
{
    class Dictionary
    {
        private Pair[] pairs = null;
        int size = default(int);
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < pairs.Length; i++)
                {
                    if (pairs[i].Key == index)
                    {
                        return pairs[i].Value;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (pairs[i].Key == index)
                    {
                        pairs[i].Value = value;
                        return;
                    }
                }
                Pair[] temp = new Pair[++size];
                if (pairs != null)
                {
                    Array.Copy(pairs, temp, size - 1);
                }
                temp[size - 1] = new Pair { Key = index, Value = value };
                pairs = temp;
            }
        }
    }
}
