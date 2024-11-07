//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using WpfAppPruebaNET.Commands;

//namespace WpfAppPruebaNET.ViewModels
//{
//    public class StopwatchViewModel : ViewModelBase
//    {
//        private TimeSpan _elapsedTime;
//        private bool _isRunning;

//        public TimeSpan ElapsedTime
//        {
//            get { return _elapsedTime; }
//            set
//            {
//                _elapsedTime = value;
//                OnPropertyChanged("ElapsedTime");
//                OnPropertyChanged("TimeDisplay");
//            }
//        }

//        public string TimeDisplay => $"Cronómetro : {ElapsedTime.Hours:D2}:{ElapsedTime.Minutes:D2}:{ElapsedTime.Seconds:D2}";

//        private ICommand _startCommand;
//        public ICommand StartCommand
//        {
//            get
//            {
//                if (_startCommand == null)
//                {
//                    _startCommand = new RelayCommand(StartStopwatch, CanStartStopwatch);
//                }
//                return _startCommand;
//            }
//        }

//        private ICommand _pauseCommand;
//        public ICommand PauseCommand
//        {
//            get
//            {
//                if (_pauseCommand == null)
//                {
//                    _pauseCommand = new RelayCommand(PauseStopwatch, CanPauseStopwatch);
//                }
//                return _pauseCommand;
//            }
//        }

//        private ICommand _stopCommand;
//        public ICommand StopCommand
//        {
//            get
//            {
//                if (_stopCommand == null)
//                {
//                    _stopCommand = new RelayCommand(StopStopwatch, CanStopStopwatch);
//                }
//                return _stopCommand;
//            }
//        }

//        private System.Windows.Threading.DispatcherTimer _timer;

//        /// <summary>
//        /// Stop watch ViewModel
//        /// </summary>
//        public StopwatchViewModel()
//        {
//            _timer = new System.Windows.Threading.DispatcherTimer();
//            _timer.Tick += Timer_Tick;
//            _timer.Interval = TimeSpan.FromSeconds(1);
//        }

//        /// <summary>
//        /// Start / Stop watch
//        /// </summary>
//        private void StartStopwatch()
//        {
//            _isRunning = true;
//            _timer.Start();
//        }

//        /// <summary>
//        /// Can Start / Stop watch
//        /// </summary>
//        /// <returns></returns>
//        private bool CanStartStopwatch()
//        {
//            return !_isRunning;
//        }

//        /// <summary>
//        /// Pause Stop watch
//        /// </summary>
//        private void PauseStopwatch()
//        {
//            _isRunning = false;
//            _timer.Stop();
//        }

//        /// <summary>
//        /// Can Pause Stop watch
//        /// </summary>
//        /// <returns></returns>
//        private bool CanPauseStopwatch()
//        {
//            return _isRunning;
//        }

//        /// <summary>
//        /// Stop / Stop watch
//        /// </summary>
//        private void StopStopwatch()
//        {
//            _isRunning = false;
//            _timer.Stop();
//            ElapsedTime = TimeSpan.Zero;
//        }

//        /// <summary>
//        /// Can Stop Stop watch
//        /// </summary>
//        /// <returns></returns>
//        private bool CanStopStopwatch()
//        {
//            return _elapsedTime != TimeSpan.Zero || _isRunning;
//        }
//        /// <summary>
//        /// Event Timer Tick 
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void Timer_Tick(object sender, EventArgs e)
//        {
//            ElapsedTime += TimeSpan.FromSeconds(1);
//        }
//    }
//}
