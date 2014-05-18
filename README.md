LegendaryReplays
===============

Open source League of Legends Replay System. Done as a weekend project over two days. Doesn't hook or modify any memory so is 100% safe. However, due to this, some features like camera modifications and automatic replay saving cannot be implemented.

A full version of LegendaryReplays can be found in [LegendaryClient](https://github.com/eddy5641/LegendaryClient/tree/Experements-Dev)

<p align="center">
  <img src="http://puu.sh/6ytzR.jpg" alt="Screenshot"/>
</p>

How to use
===================

Start by inputting your League of Legends location into settings.

Once you are done, start a game up (or find someone else you want to record a replay of). Go to lolnexus, quickfind or another website that will give you the replay settings. It should look like this:

     "C:\Riot Games\League of Legends\RADS\solutions\lol_game_client_sln\releases\0.0.1.6\deploy\League of Legends.exe" "8394" "LoLLauncher.exe" "" "spectator 192.64.169.29:8088 rUv6QlAxQ1fB+HL9HsGszlPUhuFmszpB 30015570 OC1"

Copy and paste this into the client and it will start to download the replay. You will need to wait for the game to end before the replay is fully retrieved. Once this is done, you can watch it.

Bugs
================

* Currently only replays that have been recorded from the first minute can be watched

* Tracking is kinda buggy and can result in client errors. This will be resolved in a feature update.
