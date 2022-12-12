using System.Reflection.Metadata.Ecma335;
class Controller
{
Tree<string> tree = new Tree<string>();
public static Queue<User> list = new Queue<User>();
public static List<User> list2 = new List<User>();

public void print()
  {    
    int id = 1;
    while(true)
    {

        Console.Write("Name: ");
        string name = Console.ReadLine();

        bool check = false;
        if (list.GetLength()>0)
        {
            for (int i = 0; i < list.GetLength(); i++)
            {
                if (list.Get(i).GetName == name )
                {
                check = true;
                }
            }
        }

        if (check == true)
        {
                 int count = list.GetLength();
                for (int i = 0; i < list.GetLength(); i++)
                {
                    if (list.Get(count-1).GetCount > 0)
                    {
                        int x = 1;
                        for (int n = 0; n < list.Get(count-1).GetCount; n++)
                        {
                            int p = list.Get((count-1)).GetCount;
            
                            if (p >= 0 && n < 1 )
                            {           
                                list2.Add(new User (list.Get((count-1)+x).GetName, 0, list.Get((count-1)+x).GetID, list.Get(count-1).GetID));                       
                                x++;


                            }
                            if ( p >= 1 && n > 0)
                            {

                                list2.Add(new User ((list.Get(count-1+(p))).GetName, 0, (list.Get(count-1+(p))).GetID, list.Get(count-1).GetID));                       
                                x++;
                            }
                        }
                        
                    }
                    count--;
            
                } 
        
            foreach (User item in list2)
            {
                if (name == item.GetName)
                {
                    int id2 = item.GetManegerID;
                    foreach (User item2 in list2)
                    {
                        if (id2 == item2.GetID)
                        {             
                            Console.WriteLine($"{item2.GetName}");
                            Console.WriteLine($"{list.Get(0).GetName}");
                            break;

                                    
                         }                                  
        
                    }



                    
                }
            }
            break;
        }
        else
        {
            Console.Write("Number: ");
            int input = int.Parse(Console.ReadLine());
            list.Push(new User(name,input, id, 0)); 
            id++;
  
        }
    }

  }



}


