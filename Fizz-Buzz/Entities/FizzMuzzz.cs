namespace FizzBuzz.Entities
{
    public class FizzMuzzz : FizzBuzzz
    {
        protected string _muzzGuzz = "muzz-guzz";
        protected string _guzz = "guzz";
        protected string _muzz = "muzz";

        public FizzMuzzz(List<int> inputList) : base(inputList)
        {

        }

        public override List<object> ReplaceNumbers()
        {
            for (int i = 0; i < _length; i++)
            {
                var num = _inputList[i];

                if (CheckIfFizzBuzz(num) && CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizzBuzz}-{_muzzGuzz}");
                }
                else if (CheckIfFizzBuzz(num) && CheckIfGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizzBuzz}-{_guzz}");
                }
                else if (CheckIfFizzBuzz(num) && CheckIfMuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizzBuzz}-{_muzz}");
                }
                else if (CheckIfFizz(num) && CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizz}-{_muzzGuzz}");
                }
                else if (CheckIfBuzz(num) && CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_buzz}-{_muzzGuzz}");
                }
                else if (CheckIfFizz(num) && CheckIfMuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizz}-{_muzz}");
                }
                else if (CheckIfFizz(num) && CheckIfGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_fizz}-{_guzz}");
                }
                else if (CheckIfFizzBuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _fizzBuzz);
                }
                else if (CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _muzzGuzz);
                }
                else if (CheckIfMuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _muzz);
                }
                else if (CheckIfGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _guzz);
                }
                else if (CheckIfFizz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _fizz);
                }
                else if (CheckIfBuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _buzz);
                }
            }

            return _resultList;
        }

        protected bool CheckIfMuzzGuzz(int num)
        {
            if (num % 4 == 0 && num % 7 == 0)
            {
                return true;
            }
            return false;
        }

        protected bool CheckIfMuzz(int num)
        {
            if (num % 4 == 0)
            {
                return true;
            }
            return false;
        }

        protected bool CheckIfGuzz(int num)
        {
            if (num % 7 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
