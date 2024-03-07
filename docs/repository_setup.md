# Repository Setup

- This section will show you how to correctly use this Template Repository and get it setup and working

## :one: Using the Template

This Repository is a template repository, so this allows you to copy over the existing files in this repository to your own

- First start by clicking on **"Use this Template" -> "Create a new repository"**
- This will copy over the contents of this template to your own repository
- This way, when you make commits, it will be made to your own repository rather than it attempting to make commits to the original repository

<p align="center">
    <img src="https://user-images.githubusercontent.com/98812930/224717857-749edc9e-57d7-49d3-bbc1-cacc5f963fe5.png" style="border:5px solid green" />
</p>

## :two: Create your repository

- Assign youself as the owner of this repository and give it a name & description

<p align="center">
    <img src="https://user-images.githubusercontent.com/98812930/224718114-05016496-6dbb-48c7-8507-129f8390af18.png" style="border:5px solid green" />
</p>

## :three: Clone the repository

- Open up VS 2022 or any other IDE and clone your repository so you can start coding in it

<p align="center">
    <img src="https://imgur.com/5iCaxnC.png" style="border:5px solid green" />
</p>

- In the URL box, copy and paste the URL of your repository, it can be found by clicking on **"Code"**, and then copying the link in the **HTTPS** section

- You can alternatively sign-in to GitHub on VS 2022 and select your repository

## :four: Preparing the Project

Once you have cloned the repository, we have to do 2 things before it is ready:

1. **Restore the NuGet Packages in this solution (DSharpPlus)**
2. **Setting the Token/Prefix of the Bot**

### Restoring the NuGet Packages

- To restore the NuGet packages, we have to simply **"Build"** the Solution

- To do this, click on the **"Build"** tab at the top, and then select **"Build Solution"**

<p align="center">
    <img src="https://imgur.com/FBx6qE7.png" style="border:5px solid green" />
</p>

- Once it is finished, it will generate a **/bin** folder for us in your solution folder, which will contain the application we are running when we hit **"Start" (YourSolution.exe)**. This **.exe** file is your actual console application

- In this folder, we must place in our **config.json** file which will contain our **Token & Prefix**

### The config.json file

- In order for the Bot to be able to communicate with Discord's client, we need to tell the program to connect using a Token, which we get through the **Discord Developer Portal** in the **Bot** section. 
- You can do this by editing the `config.json` file and inputting your bot's token, and then a prefix of your choice

```json
***config.json***

{
    "token":"ENTER-YOUR-TOKEN-HERE",
    "prefix":"ENTER-YOUR-PREFIX-HERE"
}
```

- Next, you need to copy this file to the build output folder of your project. Open up your project in your File Manager by right-clicking on your project name and clicking **"Open Folder in File Explorer"**

<p align="center">
    <img src="https://imgur.com/nHT0gar.png" style="border:5px solid green" />
</p>

- You will see a folder called **"bin"**, open this folder and open the **"Debug"** folder. This is where you need to copy the config.json file to

<p align="center">
    <img src="https://imgur.com/AA1OuKr.png" style="border:5px solid green" />
</p>

### NOTE: WHEN PUSHING CHANGES TO YOUR REPO

- If you push this to your own repository, bear in mind, Discord will automatically detect that your Bot token has been published online and it will reset your Token

- So in order to keep your Bot running or if you need to change the token, all you need to do is ***change the config.json file in your /bin/Debug folder and NOT the one in your solution***

### config.json in /bin/Debug

<p align="center">
    <img src="https://imgur.com/42McExa.png" style="border:5px solid green" />
</p>

*This should contain your actual token*

### config.json in Solution

<p align="center">
    <img src="https://imgur.com/obiGhPd.png" style="border:5px solid green" />
</p>

*The file should be untouched in the Config folder when you cloned this repository*

- When you make a commit and push it to the repository, doing this will prevent Discord from auto-resetting your token again
- You should never commit your **/bin/Debug** folders when you push to the repository as they contain your actual application
- The **gitignore** should avoid this automatically for you so you don't have to worry about this

## :five: Starting up the Bot

- Once you have Restored the Packages and setup the config.json file with your own Token & Prefix, you are 
ready to go

- Start the application up and you should have a nice console window with your Bot running

<p align="center">
    <img src="https://imgur.com/RQumyIu.png" style="border:5px solid green" />
</p>

# :hammer_and_wrench: Help & Support

If you need extra help with this Bot then here are some recommended support links

- **Join the Discord Server** | [samjesus8 Official Server](https://discord.com/invite/GrcaGNSfCR)
- **Join the Official DSharpPlus Server** | [DSharpPlus Official Server](https://discord.com/invite/dsharpplus)
