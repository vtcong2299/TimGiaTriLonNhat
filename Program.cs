using System;


namespace TimGiaTriLonNhat
{
    class Program
    {
        
        static void Main(string[]args)
        {
            int quantityArray;
            int i;
            float max=0;
            Console.WriteLine("Tim gia tri tai san lon nhat cua cac ty phu");
            Console.WriteLine("*******************************************");
            Console.WriteLine("\nNhap vao so luong ty phu muon so sanh tai san [gioi han 20]: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(),out quantityArray)&& quantityArray<=20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhap lai so luong ty phu muon so sanh tai san [gioi han 20]: ");
                }
            }
            float [] array = new float [quantityArray];
            for(i=0;i<quantityArray;i++)
            {
                Console.Write("Nhap vao gia tri tai san [ty USD] cua ty phu [{0}]: ", i);
                while(true)
                {
                    if(float.TryParse(Console.ReadLine(),out array[i]))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Nhap lai gia tri tai san [ty USD] cua ty phu [{0}]: ", i);
                    }
                }
                
            }
            //Cách 1
            for(i=0;i<quantityArray;i++)
            {
                if (array[i]>max)
                {
                    max=array[i];
                }
            }
            if(Array.IndexOf(array,max)==Array.LastIndexOf(array,max))
            {
                Console.WriteLine("Ty phu [{0}] la nguoi co tai san lon nhat voi gia tri: {1} [ty USD]",Array.IndexOf(array,max),max);
            }
            else
            {
                Console.Write("Cac ty phu co gia tri tai san lon nhat la: ");
                for(i=0;i<quantityArray;i++)
                {
                    if (array[i]==max)
                    {
                        Console.Write("Ty phu [{0}],  ", i);
                    }
                }
                Console.WriteLine("Voi gia tri tai san: "+max +"[ty USD]");
            }

            //Cách 2

            // Array.Sort(array);
            // max=array[quantityArray-1];
            // Console.WriteLine("Gia tri tai san lon nhat la: "+max + [ty USD]);
            
        }
    }
}