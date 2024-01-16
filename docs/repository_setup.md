# Setting up & using this Template

This article will teach you how to use this Template and create your Discord Bot in a matter of seconds

## Step 1 - Creating your Bot

- The first thing you need to do is go to the [Discord Developer Portal](https://discord.com/developers/applications) and create an application

![image](https://media.discordapp.net/attachments/1020110665161113610/1118917278357004399/image.png?width=1202&height=676)

- Create a new Application and a new Bot in this Application

![image](https://media.discordapp.net/attachments/1020110665161113610/1118917495580000316/image.png?width=1440&height=401)

- Enable all three presence Intents in the Bot. This is an essential step as the code has been set to detect all 3 intents

![image](https://media.discordapp.net/attachments/1020110665161113610/1118917495840067604/image.png)

## Step 2 - Creating a new Repository from this Template

It is now time to clone this template into a new repository. DO NOT CLONE this repository because all that is doing is creating
a clone of this template which you cannot commit changes to. You must create a new repo by using this template.

- Click on the "Use this Template" button and create a new repository

![image](https://media.discordapp.net/attachments/1020110665161113610/1118918225871257680/image.png)

- Assign yourself as the owner and give your repository a name and description. You can choose to make it Public/Private if you want

![image](https://media.discordapp.net/attachments/1020110665161113610/1118918226202599586/image.png)

- Once this is done, you should have a new Repository that looks just like the template, as shown in this example

![image](https://media.discordapp.net/attachments/1020110665161113610/1118919492567826493/image.png?width=1130&height=676)

## Step 3 - Cloning in VS2022

- Once you have created your repository, you can now clone it in VS2022 or any preferred IDE in order to start coding in it

![image](https://media.discordapp.net/attachments/1020110665161113610/1118920037936398396/image.png)

- In the Solution Explorer, you should have your whole project fully loaded

![image](https://media.discordapp.net/attachments/1020110665161113610/1118920312759783485/image.png)

## Step 4 - Restoring NuGet Packages & the config.json file

Once you have cloned the repository, it is not ready to start just yet. We have to do 2 things:

1. Restore the NuGet Packages in this solution (DSharpPlus)
2. Setting the Token/Prefix of the Bot

### Restoring the NuGet Packages

This Discord Bot uses a package library called DSharpPlus, and after you clone a repository, the packages don't load in.
So we need to **build** the project in order to load these packages in

![image](https://media.discordapp.net/attachments/1020110665161113610/1084643410834640916/image.png?width=568&height=402)

After building, if you see **1 Succeeded** in the output, it means that everything went well

![image](https://media.discordapp.net/attachments/1020110665161113610/1084643742306283560/image.png?width=1370&height=212)

### The config.json file

This json file is what actually contains the Token & Prefix for your Bot. When the bot starts up, it will attempt to read this file
and retrieve the Token & Prefix in order to set it in the bot configuration. So you must provide a valid token & prefix in this file

![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674330959993/image.png?width=1431&height=263)
*The token in this picture is just for example purposes, it is not valid*

We must then copy this file over to the **/bin/Debug** folder of your project, which is actually the folder where your application is actually stored

So open your project in the File Explorer by right clicking on your Project name in the solution

![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674591010826/image.png?width=353&height=663)

Copy your config.json file in the Config Folder and then paste it into the **/bin/Debug** folder

![image](https://media.discordapp.net/attachments/1020110665161113610/1084644674825900052/image.png?width=977&height=625)

## Pushing a commit to your repo

After you do this, to prevent your token from resetting, you must get rid of the token in your config.json file IN THE CONFIG FOLDER.
The one you pasted in the **/bin/Debug** folder should remain untouched

### config.json in /bin/Debug

![image](https://media.discordapp.net/attachments/1020110665161113610/1084646160448372776/image.png?width=1284&height=141)
This should contain your actual token

### config.json in Solution
![image](https://media.discordapp.net/attachments/1020110665161113610/1084646160674861136/image.png?width=392&height=147)

When you make a commit and push it to the repository, doing this will prevent Discord from auto-resetting your token again

You should never commit your /bin/Debug folders when you push to the repository as they contain your actual application

## Final Step - Starting up the Bot

Once you have Restored the Packages and setup the config.json file with your own Token & Prefix, you are 
ready to go

Start the application up and you should have a nice console window with your Bot

![image](https://media.discordapp.net/attachments/1020110665161113610/1084647592358584401/image.png?width=1311&height=663)

You can then start coding your commands and taking over from here on

# For more help

If you need extra help with this Bot then here are some recommended support links

- Join the Discord Server | [samjesus8 Official Server](https://discord.com/invite/GrcaGNSfCR)
- Join the Official DSharpPlus Server | [DSharpPlus Official Server](https://discord.com/invite/dsharpplus)
