Simple Patient Search Starter Project
This is a simple search application over a set of patient records. You can clone this repo or provision an instant dev environment via http://beta.codenvy.com/f?id=qu9bnf9n1h40whho

Your Mission
In BasicSearchAppCSharp you'll find the starter Web API backend code create using VS 2017, and in webapp you'll find the starter UI code. The intent is to have a search application. The UIis  a simple ember app that hits /api/patients/search endpoint. 

Please take your time and work on some basic fixes and improvements to this application, including, but not limited to:

* For the endpoint at http://localhost:<port>/api/patients/search?query=abc , 'query' parameter is supposed to be optional. If it's not present, return all patient documents. Right now you will see an error.
* If you build and run the solution, then navigate to http://localhost:<port>/api/patients/search , you'll see an error. 
* If you build and run the solution, then navigate to http://localhost:<port>/api/patients/search?query=abc , you will see empty response
* Making the PatientService filter the results it returns by a case-insensitive, partial match over the document title and contents.
* Cleaning up the code using better object-oriented design and improving readability.
* Adding unit tests around your search code.

If you have HTML/JavaScript experience, also work on some of the following:

Improve the result rendering in the UI with better styling of snippet results.
Update the search interface to debounce calls to the backend
Perform highlighting of the search term in the text results
Come up with and add a new feature to the UI, this can be anything your creativity can dream up.
After you are done, right click the src folder and download it. Email the final code to michael.barrett@qpidhealth.com

Good Luck!
