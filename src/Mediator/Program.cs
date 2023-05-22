using Mediator;

Console.Title = "Mediator";

TeamChatRoom teamChatroom = new();

var roberta = new Lawyer("Roberta");
var thamara = new Lawyer("Thamara");
var ann = new AccountManager("Ann");
var maira = new AccountManager("Maira");
var tam = new AccountManager("Tam");

teamChatroom.Register(roberta);
teamChatroom.Register(thamara);
teamChatroom.Register(ann);
teamChatroom.Register(maira);
teamChatroom.Register(tam);

ann.Send("Hi everyone, can someone have a look at file ABC123?  I need a compliance check.");
roberta.Send("On it!");
roberta.Send("Ann", "Could you join me in a Teams call?");
roberta.Send("Ann", "All good :)");
ann.SendTo<AccountManager>("The file was approved!");

Console.ReadKey();