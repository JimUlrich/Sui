using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace SupermodelUI
{
    public class SettingData
    {
        public const string EmulateNet = "Network, bool, enableNetworkCheckBox";

        #region video

        public const string New3DEngine = "Video, Bool, new3dEngineCheckBox";
        public const string QuadRendering = "Video, Bool, quadRenderingCheckBox";
        public const string VSync = "Video, Bool, vSyncCheckBox";
        public const string Throttle = "Video, Bool, throttleCheckBox";
        public const string ShowFrameRate = "Video, Bool, showFrameRateCheckBox";
        public const string Crosshairs = "Video, Bool, crosshairsCheckBox";
        public const string FullScreen = "Video, Bool, fullScreenCheckBox";
        public const string WideScreen = "Video, Bool, wideScreenCheckBox";
        public const string XResolution = "Video, int, XResolution";
        public const string YResolution = "Video, int, YResolution";

        #endregion

        #region audio

        public const string EmulateSound = "Audio, Bool, emulateSoundCheckBox";
        public const string EnableDSB = "Audio, Bool, enableDSBCheckBox";
        public const string FlipStereo = "Audio, Bool, flipStereoCheckBox";
        public const string SoundVolume = "Audio, int, soundVolumeTrackBar";
        public const string MusicVolume = "Audio, int, musicVolumeTrackBar";
        public const string Balance = "Audio, int, balanceTrackBar";

        #endregion

        #region system

        public const string CPUMultiThreaded = "Sys, int, cpuMultiThreadedCheckBox";
        public const string GPUMultiThreaded = "Sys, int, gpuMultiThreadedCheckBox";
        public const string PowerPCFrequency = "Sys, int, powerPCFrequencyUpDown";
        public const string MultiTexture = "Sys, int, multiTextureCheckBox";
        public const string InputStart1 = "sys, joy , systemInputDataGridView";
        public const string InputStart2 = "sys, joy , systemInputDataGridView";
        public const string InputCoin1 = "sys, joy , systemInputDataGridView";
        public const string InputCoin2 = "sys, joy , systemInputDataGridView";
        public const string InputServiceA = "sys, joy , systemInputDataGridView";
        public const string InputServiceB = "sys, joy , systemInputDataGridView";
        public const string InputTestA = "sys, joy , systemInputDataGridView";
        public const string InputTestB = "sys, joy , systemInputDataGridView";

        #endregion

        #region joystick

        public const string InputJoyUp = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyDown = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyLeft = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyRight = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyUp2 = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyDown2 = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyLeft2 = "joystick, joy, digitalJoystickDataGridView";
        public const string InputJoyRight2 = "joystick, joy, digitalJoystickDataGridView";

        #endregion

        #region fighting


        public const string InputPunch = "fighting, joy, digitalJoystickDataGridView";
        public const string InputKick = "fighting, joy, digitalJoystickDataGridView";
        public const string InputGuard = "fighting, joy, digitalJoystickDataGridView";
        public const string InputEscape = "fighting, joy, digitalJoystickDataGridView";
        public const string InputPunch2 = "fighting, joy, digitalJoystickDataGridView";
        public const string InputKick2 = "fighting, joy, digitalJoystickDataGridView";
        public const string InputGuard2 = "fighting, joy, digitalJoystickDataGridView";
        public const string InputEscape2 = "fighting, joy, digitalJoystickDataGridView";

        #endregion

        #region spikeout

        public const string InputShift = "spikeout, joy, digitalJoystickDataGridView";
        public const string InputBeat = "spikeout, joy, digitalJoystickDataGridView";
        public const string InputCharge = "spikeout, joy, digitalJoystickDataGridView";
        public const string InputJump = "spikeout, joy, digitalJoystickDataGridView";

        #endregion

        #region virtuastriker

        public const string InputShortPass = "striker, joy, digitalJoystickDataGridView";
        public const string InputLongPass = "striker, joy, digitalJoystickDataGridView";
        public const string InputShoot = "striker, joy, digitalJoystickDataGridView";
        public const string InputShortPass2 = "striker, joy, digitalJoystickDataGridView";
        public const string InputLongPass2 = "striker, joy, digitalJoystickDataGridView";
        public const string InputShoot2 = "striker, joy, digitalJoystickDataGridView";

        #endregion

        #region racing

        public const string InputSteeringLeft = "racing, joy, drivingSteeringDataGridView";
        public const string InputSteeringRight = "racing, joy, drivingSteeringDataGridView";
        public const string InputSteering = "racing, joy, drivingSteeringDataGridView";
        public const string InputAccelerator = "racing, joy, drivingPedalsDataGridView";
        public const string InputBrake = "racing, joy, drivingPedalsDataGridView";
        public const string InputGearShiftUp = "2speed, joy, drivingShifterDataGridView";
        public const string InputGearShiftDown = "2speed, joy, drivingShifterDataGridView";
        public const string InputGearShift1 = "4speed, joy, drivingShifterDataGridView";
        public const string InputGearShift2 = "4speed, joy, drivingShifterDataGridView";
        public const string InputGearShift3 = "4speed, joy, drivingShifterDataGridView";
        public const string InputGearShift4 = "4speed, joy, drivingShifterDataGridView";
        public const string InputGearShiftN = "4speed, joy, drivingShifterDataGridView";
        public const string InputVR1 = "vr4, joy, drivingViewDataGridView";
        public const string InputVR2 = "vr4, joy, drivingViewDataGridView";
        public const string InputVR3 = "vr4, joy, drivingViewDataGridView";
        public const string InputVR4 = "vr4, joy, drivingViewDataGridView";
        public const string InputViewChange = "vr1, joy, drivingViewDataGridView";
        public const string InputHandBrake = "handbrake, joy, drivingPedalsDataGridView";
        public const string InputRearBrake = "harley, joy, drivingPedalsDataGridView";
        public const string InputMusicSelect = "harley, joy, drivingViewDataGridView";

        #endregion

        #region starwars

        public const string InputAnalogJoyLeft = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyRight = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyUp = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyDown = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyX = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyY = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyTrigger = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyEvent = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyTrigger2 = "starwars, joy, drivingViewDataGridView";
        public const string InputAnalogJoyEvent2 = "starwars, joy, drivingViewDataGridView";

        #endregion

        #region virtuaon

        public const string InputTwinJoyLeft1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyLeft2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyRight1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyRight2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyUp1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyUp2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyDown1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyDown2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyShot1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyShot2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyTurbo1 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyTurbo2 = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyTurnLeft = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyTurnRight = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyForward = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyReverse = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyStrafeLeft = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyStrafeRight = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyJump = "von, joy, digitalJoystickDataGridView";
        public const string InputTwinJoyCrouch = "von, joy, digitalJoystickDataGridView";

        #endregion

        #region digitalgun

        public const string InputGunLeft = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunRight = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunUp = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunDown = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunX = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunY = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputTrigger = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputOffscreen = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputAutoTrigger = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunLeft2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunRight2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunUp2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunDown2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunX2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputGunY2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputTrigger2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputOffscreen2 = "digitalgun, joy, digitalJoystickDataGridView";
        public const string InputAutoTrigger2 = "digitalgun, joy, digitalJoystickDataGridView";

        #endregion

        #region analoggun

        public const string InputAnalogGunLeft = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunRight = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunUp = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunDown = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunX = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunY = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogTriggerLeft = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogTriggerRight = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunLeft2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunRight2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunUp2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunDown2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunX2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogGunY2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogTriggerLeft2 = "analoggun, joy, digitalJoystickDataGridView";
        public const string InputAnalogTriggerRight2 = "analoggun, joy, digitalJoystickDataGridView";

        #endregion

        #region skichamp

        public const string InputSkiLeft = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiRight = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiUp = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiDown = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiX = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiY = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiPollLeft = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiPollRight = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiSelect1 = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiSelect2 = "ski, joy, digitalJoystickDataGridView";
        public const string InputSkiSelect3 = "ski, joy, digitalJoystickDataGridView";

        #endregion

        #region magicaltruck

        public const string InputMagicalLeverUp1 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalLeverDown1 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalLeverUp2 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalLeverDown2 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalLever1 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalLever2 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalPedal1 = "truck, joy, digitalJoystickDataGridView";
        public const string InputMagicalPedal2 = "truck, joy, digitalJoystickDataGridView";

        #endregion

        #region fishing

        public const string InputFishingRodLeft = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingRodRight = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingRodUp = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingRodDown = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickLeft = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickRight = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickUp = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickDown = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingRodX = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingRodY = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickX = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingStickY = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingReel = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingCast = "fishing, joy, digitalJoystickDataGridView";
        public const string InputFishingSelect = "fishing, joy, digitalJoystickDataGridView";

        #endregion

        #region resolutions

        public enum resolutions
        {       
            x640y480,
            x1024y768,
            x1366y768,
            x1920y1080
        }

        #endregion
    }
}
