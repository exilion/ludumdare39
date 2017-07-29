using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudumDare39
{
    class GameState
    {
        public enum Brightness { low, medium, high };
        public enum Volume { mute, low, medium, high };

        private bool wifiOn;
        private bool bluetoothOn;
        private Volume soundVolume;
        private Brightness screenBrightness;
        private long batteryValue;
        
        private Minigame currentMinigame;

        public GameState()
        {
            wifiOn = false;
            bluetoothOn = false;
            soundVolume = Volume.medium;
            screenBrightness = Brightness.medium;
            batteryValue = 100;
        }

        public Minigame GetMinigame()
        {
            return currentMinigame;
        }

        public void SetMinigame(Minigame newMinigame)
        {
            this.currentMinigame = newMinigame;
        }

        public Brightness GetBrightness()
        {
            return screenBrightness;
        }

        public Volume GetVolume()
        {
            return soundVolume;
        }

        public void SetBrightness(Brightness screenBrightness)
        {
            this.screenBrightness = screenBrightness;
        }

        public void SetVolume(Volume soundVolume)
        {
            this.soundVolume = soundVolume;
        }

        public long GetBatteryValue()
        {
            return batteryValue;
        }

        public void SetBatteryValue(long batteryValue)
        {
            this.batteryValue = batteryValue;
        }

        public bool WifiOn()
        {
            return wifiOn;
        }

        public void ToggleWifi()
        {
            wifiOn = !wifiOn;
        }
        
        public bool BluetoothOn()
        {
            return bluetoothOn;
        }

        public void ToggleBluetooth()
        {
            bluetoothOn = !bluetoothOn;
        }
    }
}
