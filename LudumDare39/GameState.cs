using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudumDare39
{
    public class GameState
    {
        public enum Brightness { low, medium, high };
        public enum Volume { mute, low, medium, high };

        private Volume soundVolume;
        private Brightness screenBrightness;
        private long batteryValue;
        
        public GameState()
        {
            soundVolume = Volume.medium;
            screenBrightness = Brightness.medium;
            batteryValue = 1000;
        }
        
        public void UpdateBattery()
        {
            long currentBattery = GetBatteryValue();
            long usedBattery = 0;

            switch (soundVolume)
            {
                case Volume.mute:
                    break;
                case Volume.low:
                    usedBattery += 5;
                    break;
                case Volume.medium:
                    usedBattery += 10;
                    break;
                case Volume.high:
                    usedBattery += 15;
                    break;
            }
            switch (screenBrightness)
            {
                case Brightness.low:
                    usedBattery += 10;
                    break;
                case Brightness.medium:
                    usedBattery += 15;
                    break;
                case Brightness.high:
                    usedBattery += 20;
                    break;
            }
            
            SetBatteryValue(currentBattery - usedBattery);
        }
        
        public void SetBrightness(Brightness screenBrightness)
        {
            this.screenBrightness = screenBrightness;
        }

        public Brightness GetBrightness()
        {
            return screenBrightness;
        }

        public void SetVolume(Volume soundVolume)
        {
            this.soundVolume = soundVolume;
        }

        public Volume GetVolume()
        {
            return soundVolume;
        }

        public long GetBatteryValue()
        {
            return batteryValue;
        }

        public void SetBatteryValue(long batteryValue)
        {
            this.batteryValue = batteryValue;
        }
    }
}
