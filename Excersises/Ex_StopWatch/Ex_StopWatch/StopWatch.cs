namespace Ex_StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime { get; set; }
        private DateTime _endTime { get; set; }

        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("The watch has already been set");
            }
            else
            {
                _isRunning = true;
                _startTime = DateTime.Now;
            }
        }
        public void Stop()
        {
            if (_isRunning)

            {
                _isRunning = false;
                _endTime = DateTime.Now;
                Console.WriteLine(_endTime - _startTime);
            }

        }
    }
}