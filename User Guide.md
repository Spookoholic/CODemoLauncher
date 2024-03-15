# Champions Online Demo Launcher User Guide
The Champions Online Demo Launcher is an application meant to make playing back .demo files recorded in Champions Online quick, painless, and easy. This application is essentially a "port" of the [Star Trek Online Demo Launcher](https://github.com/STOCD/STODemoLauncher), only modified to work with Champions Online instead of Star Trek Online. 

> [!WARNING]
> This application is meant to work *only* with Champions Online!<br>
> If you need to play Star Trek Online demos, please use the [Star Trek Online Demo Launcher](https://github.com/STOCD/STODemoLauncher) instead.


<br>



## How to Install
Setting the Champions Online Demo Launcher is pretty simple. Just follow these steps:
1. Download the latest version of the app from the [Releases](https://github.com/Spookoholic/CODemoLauncher/releases) page and launch the aplication.
2. Upon first boot, the application will automatically try to find your Champions Online install location.
3. Once the app has found your CO install, it will launch and automatically load any .demo files it finds. The app is now properly configured and ready to use!

> [!IMPORTANT]
> If the application is unable to automatically locate your Champions Online install location, the program will alert you and give you the option to manually set your path. 


<br>

You can also set the install path after the initial setup by following these steps:
1. From the top menu, select the **Tools** menu.
2. Select **Options**
3. The Options window should pop up, from here select the **Advanced** tab.
4. In the **Game Client** section, you have the ability to browse to and select your Champions Online install locations.

<br>

> [!NOTE]
> This application saves its settings to file located at %APPDATA%\Roaming\CoDemoLauncher\config.ini. 

<br>

## How to Use

<p align="center">
  <img src="https://i.imgur.com/kGhoCW9.png" alt="Sublime's custom image"/>
</p>


### Playing a Demo
- To play a demo, simply select a demo from the list and then click the **green Playback demo button.** located on the top menu or the **Tools** drop down menu.
- To a play a demo *without* any user interface elements, select a demo from the list and then click the **yellow Playback demo button** located on the top menu or the **Tools** drop down menu.
- If your demos are not showing up on the list, try hitting the **Refresh button** to refresh the list and double check that your CO install paths are pointing to the correct places.
<br>

### Rendering a Demo
- To render a demo, select a demo from the list and then click the **red Render demo button** located on the top menu or the **Tools** drop down menu. This will then open up the **Render Demo** window, allowing you to set additional options, settings, and parameters. Clicking the **OK** button from this window will begin the rendering process.
- To record audio from a demo, select a demo from the list and then click the **blue Record demo audio button** located on the top menu or the **Tools** drop down menu. This will open up the **Record Demo Audio** window, allowing you to set additional options before recording audio. Clicking the **OK button** will begin the audio recording process.

> [!WARNING]
> Rendering demo will cause Champions Online to export each frame of a .demo file as a high quality individual image. These frames are then meant to be stitched back together along side the recorded audio using a video editing program (such as Adobe Premiere) to create the full video.<br><br>
> As a result, rendering a .demo file can be performance intensive and can eat up a not insignficiant amount of storage space. Make sure you have the time/storage ready *before* you render a demo!

<br>

### Editing a Demo using the CO Demo Launcher

TODO: Finish this section.
