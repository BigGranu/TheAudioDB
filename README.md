TheAudioDB
==========

.Net data bindings for [TheAudioDB](http://www.theaudiodb.com/)

Some of features are:
 * Search Artistinfo
 * Search Albuminfo
 * Search Trackinfo
 * Search Discography

For an APIKey go to [TheAudioDB Forum](http://www.theaudiodb.com/forum/viewtopic.php?f=6&t=8)

Any Examples:

```c#
// Set a global Apikey
API api = new API("apikey"); 
Track t2 = new Track("Coldplay", "Don't Panic");
// or use the Key directly
Track t3 = new Track("Coldplay", "Don't Panic", "apikey");
```

Artist
```c#
Artist a = new Artist("Coldplay");
Artist a1 = new Artist(new Guid("cc197bad-dc9c-440d-a5b5-d52ba2e14234"));
```

Discography
```c#
Discography d = new Discography("Coldplay");
Discography d2 = new Discography(new Guid("cc197bad-dc9c-440d-a5b5-d52ba2e14234"));
```

Album
```c#
Album ab1 = new Album("Coldplay", "Parachutes");
Album ab2 = new Album("Coldplay", "");
Album ab3 = new Album("", "Parachutes");
```

Track
```c#
Track t = new Track("Coldplay", "Don't Panic");
```
