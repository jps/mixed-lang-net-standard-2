namespace DataAccess

module UserGetter =
    type User = { Name : string; Age : int }
    let Get name =
        {Name = name; Age = 1234}
