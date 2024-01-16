namespace FizzBuzz.Entities
{
    public class FizzBuzzz : BaseFizz
    {
        public FizzBuzzz(List<int> inputList) : base(inputList)
        {

        }

        public override List<object> ReplaceNumbers()
        {
            for (int i = 0; i < _length; i++)
            {
                var num = _inputList[i];
                if (CheckIfFizzBuzz(num))
                {
                    _resultList.RemoveAt(i);
                    _resultList.Insert(i, _fizzBuzz);
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

        protected virtual bool CheckIfFizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                return true;
            }
            return false;
        }

        protected virtual bool CheckIfFizz(int num)
        {
            if (num % 3 == 0)
            {
                return true;
            }
            return false;
        }

        protected virtual bool CheckIfBuzz(int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
