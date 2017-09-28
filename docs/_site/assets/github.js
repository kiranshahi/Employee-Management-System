jQuery.githubUser = function(username, callback) {
   jQuery.getJSON('https://api.github.com/users/'+username+'/repos?callback=?',callback)

   //Need to display repo based on recent update i.e. use updated "String parameter"

}
 
jQuery.fn.loadRepositories = function(username) {
    this.html("<span>Querying GitHub for " + username +"'s repositories...</span>");
     
    var target = this;
    $.githubUser(username, function(data) {
        var repos = data.data; // JSON Parsing   
        
        var list = $('<ul class="list-group">');
        target.empty().append(list);
        $(repos).each(function(index, repos) {
            if (this.name != (username.toLowerCase()+'.github.com') && this.fork == false) {
                
                    list.append('<li class="list-group-item"><a href="'+ (this.homepage?this.homepage:this.html_url) +'">' + this.name + '<em>'+(this.language?('('+this.language+')'):'')+'</em></a></li>');
            }
            return index < 10;

        });      
      });
};