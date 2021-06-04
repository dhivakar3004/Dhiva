// const http=require('http');

// const server=http.createServer();



// console.log("Welcome to JS");

// function print()
// {
//     console.log("Welcome LIne inside the async");

// }
// setTimeout(()=>{
//     console.log("Line inside the async");
// },1000)
// console.log("Line after the async");

// const http=require('http');
// const server=http.createServer(()=>{console.log("When the server is called");});
// server.listen(2500);
// console.log("server started");

// const http=require('http');
// const server=http.createServer((req,res)=>{
//     //res.write("HEllo World");
//     //res.end();
    
//     console.log(req.method);
//     console.log(req.url);
// });
// server.listen(2500);
// console.log("server started");


const http=require('http');
const server=http.createServer((req,res)=>{
       
        const url=req.url;
        const method=req.method;
        console.log(url+" "+method);
        if(url == "/service" && method == "GET")
        {
            res.write("<h1>Services</h1>");
            res.write("<form method='POST'><input type='text' name='txtMessage'><input type='text' name='sectxtMessage'><button type='submit'> Send</form>")
            return res.end();
        }
        if(url == "/service" && method == "POST")
        {   let userMessage=[];
            let message="Invalid username or password";
            req.on('data',(myData)=>{
                userMessage.push(myData);
            })
            req.on('end',()=>{
                const parsedData=Buffer.concat(userMessage).toString();
                const user=parsedData.split('&');
                let username = user[0].split('=')[1]
                let password = user[1].split('=')[1]
                console.log(username+ " from the inside  "+password)
                if(username=='Dhiva' && password=="1234")
                    message="Welcome User";
                console.log(message);               
            })
            res.write("<h1> POST DONE</h1>")
            return res.end();
        }
        if(url == "/")
        {
            res.write("<h1>Home</h1>");
            return res.end();
        }
        if(url == "/about")
        {
            res.write("<h1>About</h1>");
            return res.end();
        }
        res.write("<h1> NO Such pages</h1>");
        res.end();
});
server.listen(2500);
console.log("server started");