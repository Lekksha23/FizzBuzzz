namespace FizzBuzz.Entities
{
    public class GoodBoy : FizzMuzzz
    {
        protected string _goodBoy = "good-boy";
        protected string _dog = "dog";
        protected string _cat = "cat";

        public GoodBoy(List<int> inputList) : base(inputList)
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
                    _resultList.Insert(i, $"{_goodBoy}-{_muzzGuzz}");
                }
                else if (CheckIfFizzBuzz(num) && CheckIfGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_goodBoy}-{_guzz}");
                }
                else if (CheckIfFizzBuzz(num) && CheckIfMuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_goodBoy}-{_muzz}");
                }
                else if (CheckIfFizz(num) && CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_dog}-{_muzzGuzz}");
                }
                else if (CheckIfBuzz(num) && CheckIfMuzzGuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, $"{_cat}-{_muzzGuzz}");
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
                    _resultList.Insert(i, _goodBoy);
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
                    _resultList.Insert(i, _dog);
                }
                else if (CheckIfBuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _cat);
                }
            }

            return _resultList;
        }

    }
}
