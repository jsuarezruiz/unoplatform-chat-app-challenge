using ChatApp.Models;
using Microsoft.UI;
using System.Collections.Generic;

namespace ChatApp.Services
{
    public class MessageService
    {
        static MessageService _instance;

        public static MessageService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MessageService();

                return _instance;
            }
        }

        readonly User user1 = new User
        {
            Name = "Alaya Cordova",
            Image = "ms-appx:///Assets/emoji1.png",
            Color = Colors.LightBlue
        };
        readonly User user2 = new User()
        {
            Name = "Cecily Trujillo",
            Image = "ms-appx:///Assets/emoji2.png",
            Color = Colors.LightCoral
        };
        readonly User user3 = new User()
        {
            Name = "Eathan Sheridan",
            Image = "ms-appx:///Assets/emoji3.png",
            Color = Colors.LightSeaGreen
        };
        readonly User user4 = new User()
        {
            Name = "Komal Orr",
            Image = "ms-appx:///Assets/emoji4.png",
            Color = Colors.LightPink
        };
        readonly User user5 = new User()
        {
            Name = "Sariba Abood",
            Image = "ms-appx:///Assets/emoji5.png",
            Color = Colors.LimeGreen
        };
        readonly User user6 = new User()
        {
            Name = "Justin O'Moore",
            Image = "ms-appx:///Assets/emoji6.png",
            Color = Colors.LightSkyBlue
        };
        readonly User user7 = new User()
        {
            Name = "Alissia Shah",
            Image = "ms-appx:///Assets/emoji7.png",
            Color = Colors.LightSeaGreen
        };
        readonly User user8 = new User()
        {
            Name = "Antoni Whitney",
            Image = "ms-appx:///Assets/emoji8.png",
            Color = Colors.LightYellow
        };
        readonly User user9 = new User()
        {
            Name = "Jaime Zuniga",
            Image = "ms-appx:///Assets/emoji9.png",
            Color = Colors.LightGray
        };
        readonly User user10 = new User()
        {
            Name = "Barbara Cherry",
            Image = "ms-appx:///Assets/emoji10.png",
            Color = Colors.LightBlue
        };

        public List<User> GetUsers()
        {
            return new List<User>
            {
                user1, user2, user3, user4, user5, user6, user7, user8, user9, user10
            };
        }
        public List<Message> GetChats()
        {
            return new List<Message>
            {
                new Message
                {
                  Sender = user6,
                  Time = "18:32",
                  Text = "Hey there! What\'s up? Is everything ok?",
                },
              new Message
              {
                Sender = user1,
                Time = "14:05",
                Text = "Can I call you back later?, I\'m in a meeting.",
              },
              new Message
              {
                Sender = user3,
                Time = "14:00",
                Text = "Yeah. Do you have any good song to recommend?",
              },
              new Message
              {
                Sender = user2,
                Time = "13:35",
                Text = "Hi! I went shopping today and found a nice t-shirt.",
              },
              new Message
              {
                Sender = user4,
                Time= "12:11",
                Text= "I passed you on the ride to work today, see you later.",
              },
            };
        }

        public List<Message> GetMessages(User sender)
        {
            return new List<Message> {
              new Message
              {
                Sender = sender,
                Time = "18:35",
                Text= "Hey there! What\'s up?",
              },
              new Message
              {
                Sender = null,
                Time = "18:36",
                Text = "Nothing. Just chilling and watching YouTube. What about you?",
              },
              new Message
              {
                Sender = sender,
                Time = "18:39",
                Text =
                    "Same here! Been watching YouTube for the past 5 hours despite of having so much to do! 😅",
              },              
              new Message
              {
                Sender = sender,
                Time = "18:39",
                Text = "It\'s hard to be productive, man 😞",
              },
              new Message
              {
                Sender = null,
                Time = "18:42",
                Text = "Yeah I know. I\'m in the same position 😂",
              },
            };
        }
    }
}