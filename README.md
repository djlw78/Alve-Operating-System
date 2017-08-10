# Alve Operating System
A Cosmos based Operating System developped in C# made by Alexy DA CRUZ (GeomTech) and Valentin Charbonnier (valentinbreiz).

## Current features
Please read the [TODO](https://github.com/Alve-OS/Alve-Operating-System/blob/master/TODO.md) file to know what will be added soon.

* Restart.
* Shutdown.
* Basic command interpreter.
* Virtual FileSystem.
* Multilanguage support.
* Exception with screen of death.
* Extended ASCII support.
* Multi users.
* Secured Users With MD5 Encryption.
* Text Editor (Liquid Editor)

## Screenshots

Login:

![Alve Operating System](https://image.noelshack.com/fichiers/2017/32/4/1502379821-alve4.png)

Shell:

![Alve Operating System](https://image.noelshack.com/fichiers/2017/32/4/1502379822-alve5.png)

![Alve Operating System](https://image.noelshack.com/fichiers/2017/32/4/1502320901-alve2.png)

![Alve Operating System](https://image.noelshack.com/fichiers/2017/31/4/1501777813-alve5.png)

## Want to try Alve?
Download VMWare [at this address](https://my.vmware.com/en/web/vmware/free#desktop_end_user_computing/vmware_workstation_player/12_0). Install and run it.

Now click on "Create a new virtual machine", select the [Alve ISO](https://github.com/Alve-OS/Alve-Operating-System/releases/download/0.2-100820171748/Alve-0.2-100820171748.iso) and click the "Next" button.

Now click on "Other" for "Guest operating system" and "Other" for version, click "Next" again, select "Store virtual disk as a single file" and select "Finish". 

The Virtual File System won't work so go to "C:\Users\username\Documents\Virtual Machines\Other" and replace the "Other.vmdk" by [this file](https://github.com/CosmosOS/Cosmos/raw/master/Cosmos/Build/VMWare/Workstation/Filesystem.vmdk).

Now you can select Alve (Other) and click on "Play Virtual Machine".

## How to compile Alve sources ?
First, clone [our modified version of Cosmos](https://github.com/Alve-OS/Cosmos), run the "install-VS2017.bat" file and wait until the installation is done. 

Now clone [this repository](https://github.com/Alve-OS/Alve-Operating-System) then inside the folder Alve OS, run Alve OS.sln and select "build" once Visual Studio 2017 has loaded.

## Commands

Shutdown (to do an ACPI Shutdown) :
```
shutdown
```

Reboot (to do a CPU Reboot) :
```
reboot
```

Clear (to clear the console)
```
clear
```

Echo (to echo some text)
```
echo text
```

Help (to show availables commands)
```
help
```

Cd .. (to navigate to the parent folder)
```
cd ..
```

Cd (to navigate to a folder)
```
cd directory
```

Dir (to list directories and files)
```
dir
```

Mkdir (to create a directory)
```
mkdir directory
```

Rmdir (to remove a directory)
```
rmdir directory
```

Mkfil (to create a file and edit it in Liquid Editor)
```
mkfil file.txt
```

Prfil (to edit a file in Liquid Editor)
```
prfil file.txt
```

Rmfil (to remove a file)
```
rmfil file.txt
```

Vol (to list volumes)
```
vol
```

Systeminfo (to display system informations)
```
systeminfo
```

Ver (to display system version and revision)
```
ver
```

TextColor (to change console foreground color)
```
textcolor 1 (choose an ID)
```

BackgroundColor (to change console background color)
```
backgroundcolor 1 (choose an ID)
```

Logout (to disconnect and change of user)
```
logout
```

Settings (to access to the settings of Alve)
```
settings {args}
```


