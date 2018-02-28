In console add jQUery:

var jq = document.createElement('script');
jq.src = "https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js";
document.getElementsByTagName('head')[0].appendChild(jq);

Then make Ajax call to Controller: 

var data = {"Id":"0", "Name":"Testdata2"}
$.ajax({
    type: "POST",
    dataType : "json",
    contentType: "application/json; charset=utf-8",
    data : JSON.stringify(data),
    url: "http://localhost:5000/conf/values/update"
});
