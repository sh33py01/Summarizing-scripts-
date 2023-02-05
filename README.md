# Summarizing-scripts-
Two different summarizing scripts, that summarize information from a given link

-Script one
The script then checks if a URL is provided as an argument. If not, it displays a usage message and exits.
The script then uses the curl command to download the file from the URL, and pipes the output to awk. 
The awk script splits the text into sentences using the RS variable and the ORS variable, which specify the record separator and the output record separator,
respectively. The script then keeps sentences that have more than 20 words and outputs the first 10 sentences.


-C# Code
The code then uses the WebClient.DownloadString method to download the text from the URL. It then uses a regular expression to split the text into sentences. The regular expression matches the end of a sentence that is followed by a whitespace character and a letter.
Finally, the code iterates over the sentences, keeps sentences that have more than 20 words, and outputs the first 10 sentences.
