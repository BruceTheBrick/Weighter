using Android.Content;
using Android.Hardware;
using Android.OS;

namespace Weighter.Core;

public class MotionSensorManager
{
    private readonly SensorManager _sensorManager;
    private readonly Sensor? _stepSensor;
    private StepListener? _listener;

    public event EventHandler<StepsChangedEvent>? StepsChanged;

    public MotionSensorManager()
    {
        _sensorManager = (SensorManager)Android.App.Application.Context.GetSystemService(Context.SensorService)!;
        _stepSensor = _sensorManager.GetDefaultSensor(SensorType.StepCounter);
    }

    public bool IsAvailable => _stepSensor is not null;

    public void Start()
    {
        if (_stepSensor is null)
        {
            throw new NotSupportedException("This device does not have a step counter sensor.");
        }

        _listener = new StepListener(this);
        _sensorManager.RegisterListener(_listener, _stepSensor, SensorDelay.Normal);
    }

    public void Stop()
    {
        if (_listener is null)
        {
            return;
        }

        _sensorManager.UnregisterListener(_listener);
        _listener = null;
    }

    private class StepListener : Java.Lang.Object, ISensorEventListener
    {
        private readonly MotionSensorManager _owner;

        public StepListener(MotionSensorManager owner)
        {
            _owner = owner;
        }

        public void OnSensorChanged(SensorEvent? sensorEvent)
        {
            if (sensorEvent?.Values is null)
            {
                return;
            }

            var totalSteps = sensorEvent.Values[0];
            var timestamp = TimestampToDateTimeOffset(sensorEvent.Timestamp);
            _owner.StepsChanged?.Invoke(_owner, new StepsChangedEvent(totalSteps, timestamp));
        }

        public void OnAccuracyChanged(Sensor? sensor, SensorStatus accuracy)
        {
        }
    }
    
    private static DateTimeOffset TimestampToDateTimeOffset(long sensorTimestamp)
    {
        var now = DateTimeOffset.UtcNow;
        var elapsedNow = SystemClock.ElapsedRealtimeNanos();
        var elapsedSinceEvent = elapsedNow - sensorTimestamp;
        return now.AddTicks(-(elapsedSinceEvent / 100));
    }
}

public record struct StepsChangedEvent(float Steps, DateTimeOffset Timestamp);