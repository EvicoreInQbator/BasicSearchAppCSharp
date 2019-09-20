# Simple Patient Search Starter Project

This is a simple search application over a set of patient records. Please clone this repo.

## Your Mission

In BasicSearchAppCSharp you'll find the starter Web API backend code create using Visual Studio 2017, and in webapp you'll find the starter UI code. The intent is to have a search application. The patient documents are contained in Resources folder. The UI is a simple ember app that hits /api/patients/search endpoint and displays returned results.

Please take your time and work on some basic fixes and improvements to this application, including, but not limited to:

* For the endpoint at /api/patients/search?query=abc , 'query' parameter is supposed to be optional. If it's not present, return all patients with all documents. Right now if you build, run, and navigate to that endpoint using the browser, you will see an error.
* However, if you build, run, and navigate to /api/patients/search?query=abc , you will see response with empty objects. This also needs fixing.
* Make the 'query' parameter work, namely PatientsController filter the results it returns by a case-insensitive, partial match over the document title and contents.
* Clean up the code using better object-oriented design and improving readability.
* Add unit tests around your search code.

If you have HTML/JavaScript experience, also work on some of the following:

Improve the result rendering in the UI with better styling of snippet results.
Update the search interface to debounce calls to the backend
Perform highlighting of the search term in the text results
Come up with and add a new feature to the UI, this can be anything your creativity can dream up.
After you are done, please share your work with dbaranovsky1@evicore.com

Good Luck!
