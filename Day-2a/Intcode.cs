using System;

namespace Day_2a
{
    class Intcode
    {
        private int _pointer;
        private readonly int[] _code;

        public Intcode(int[] code) => _code = code;

        public void Process()
        {
            
            while (true)
            {
                int command = ConsumeOpCode();
                int a, b, t;
                switch (command)
                {
                    case 1:
                        a = ConsumeOpCode();
                        b = ConsumeOpCode();
                        t = ConsumeOpCode();
                        _code[t] = _code[a] + _code[b];
                        break;
                    case 2:
                        a = ConsumeOpCode();
                        b = ConsumeOpCode();
                        t = ConsumeOpCode();
                        _code[t] = _code[a] * _code[b];
                        break;
                    case 99:
                        return;
                }
            }
        }

        public void PrintValue(int index) => Console.WriteLine(_code[index]);

        private int ConsumeOpCode() => _pointer < _code.Length ? _code[_pointer++] : 99;
    }
}
