namespace DataAccess

open FSharp.Data

module UserGetter =
    type User = { Name : string; Age : int }
    type User2 = JsonProvider<""" { "name":"John", "age":94 } """>
    
    let Get name =
        {Name = name; Age = 1234}
    let GetUserById id =
        ("James", 1234)
    let GetUserByAge age =
        let user2 = User2.Parse(""" { "name":"Tomas", "age":4 } """)
        let user = User2.Load(""" { "name":"Tomas", "age":4 } """)
        user2