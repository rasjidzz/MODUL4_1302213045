using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_1302213045
{
    public class PosisiKarakterGame
    {
        enum State {BERDIRI, JONGKOK, TENGKURAP, TERBANG, STOP};
        public void mulai()
        {
            State state= State.BERDIRI;
            string[] statename = { "BERDIRI", "JONGKOK", "TENGKURAP", "TERBANG", "STOP"};
            while (state != State.STOP)
            {
                Console.WriteLine("\nPosisi : "+state);
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.BERDIRI:
                        if (command == "w")
                        {
                            state= State.TERBANG;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if (command == "s")
                        {
                            state = State.JONGKOK;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }else if(command == "e")
                        {
                            state = State.STOP;
                        }
                        break;
                    case State.JONGKOK:
                        if (command == "w") {
                            state = State.BERDIRI;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if (command == "s")
                        {
                            state = State.TENGKURAP;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else if (command == "e")
                        {
                            state = State.STOP;
                        }
                        break;
                    case State.TENGKURAP:
                        if (command == "w")
                        {
                            state = State.JONGKOK;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if (command == "e")
                        {
                            state = State.STOP;
                        }
                        break;
                    case State.TERBANG:
                        if (command == "s")
                        {
                            state = State.BERDIRI;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        else if (command == "x")
                        {
                            state = State.JONGKOK;
                        }
                        else if (command == "e")
                        {
                            state = State.STOP;
                        }
                        break;
                }
            }
        }
    }
}
