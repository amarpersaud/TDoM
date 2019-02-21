# TDoM
Youtube and Soundcloud based streaming program like Spotify.

# What is it
This program (will be an android app / desktop application) is designed to make use of the ITunes API to look for songs, albums, and artists, and then link them to youtube video and soundcloud audio uploads. Then, these songs can be viewed and listened to like in Spotify, without advertisements.

#How does (or rather, will) it do it?
The program relies on the user to find the relevant associated album and songs through the ITunes API utilized by the program, and the Youtube and soundcloud uploads. The program uses YoutubeExplode to scrape the youtube website in order to get around the Youtube Data API call limitations. The ITunes API also has a 20 search/minute limitation, but this can be pushed down onto the user as long as data is cached user side.

