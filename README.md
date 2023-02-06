# Subtitles Fix application
This is an application that fixes the subtitles time duration 
from a file with format SubRipper (.srt) or (.txt).

The solution is designed with a Class Library that holds the logic of the application.
It has a Windows Forms application for the user interface and a Console application 
with some test files and the code to access the class library directly.


## Problem to solve:
A subtitle file where the start and end time do not last long enough to read.
For example, if the text only shows on the screen for 1 second, it is too fast. 
The objective of the application is to modify the subtitles in order to make it last longer, 
so it sets the end time to be equal to the next subtitle start time.

### Example of the application subtitle fix:
* Original subtitle with 1 second time duration

<pre>
	2
	00:00:10,159 --> 00:00:11,159
	The people in the back,
	can you hear me clearly?

	3
	00:00:13,030 --> 00:00:14,030
	OK, good.
</pre>

* Subtitles fix will change the first subtitle end time (00:00:11,159) 
to be equal to the second subtitle start time (00:00:13,030)

<pre>
	2
	00:00:10,159 --> 00:00:13,030
	The people in the back,
	can you hear me clearly?

	3
	00:00:13,030 --> 00:00:14,030
	OK, good.
</pre>


## File subtitle requirement:
The application only accepts files with SRT format and extensions .srt or .txt

### SRT (SubRip file format) (.srt)
A SRT file is saved in the SubRip file format with the .srt extension. 

### SRT file Structure
In the SRT format each subtitle has four parts:

1- A numeric counter indicating the number or position of the subtitle.

2- Start and end time of the subtitle separated by -–> characters

3- Subtitle text in one or more lines.

4- A blank line indicating the end of the subtitle.

### SRT file Example
<pre>
	1
	00:05:00,400 --> 00:05:15,300
	This is an example of
	a subtitle.

	2
	00:05:16,400 --> 00:05:25,300
	This is another example of
	a subtitle - 2nd subtitle.
</pre>