<h3>AireLogic Lyrics Analyser</h3>
AireLogic Lyrics Analyser returns song statistics for a given number of artists.
It also offers optional loglevel information for more details on requests and timings.
<h3>Artist Comparison</h3>
The analyser can handle any number of artists by passing in space separated artist names. The min, max and average words for each artist will be displayed for direct comparison.

<h3>Extract files</h3>

     Clone the repository locally.
  
     Unzip the publish.zip file
  
     cd publish
  
<h3>Usage:</h3>
     
     dotnet Airelogic.LyricsAnalyser.dll artist1
     
     dotnet Airelogic.LyricsAnalyser.dll artist1 [artist2...]
     
     dotnet Airelogic.LyricsAnalyser.dll artist1 [artist2...] [/loglevel trace]

     use double quotes around multi words artists, ie "Rolling Stones"
     
     click enter after running the application to terminate.
<h3>Run unit tests</h3>
At the root of the repository

     cd LyricsAnalyser/
     
     dotnet test Airelogic.LyricsAnalyser.Test/Airelogic.LyricsAnalyser.Test.csproj
     
<h3>Performance Improvement</h3>
Performance improvements can be made by caching previous api stat results and therefore not needing to call the api.
I also explored using separate threads the shave a few more milliseconds, which did let me observer all requests go out before seeing reponses.
This however didnt improve overall performance as the bottleneck is the api itself.

