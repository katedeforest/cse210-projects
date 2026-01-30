using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates 3-4 videos, sets the appropriate
        // values, and for each one add a list of 3-4 comments (with the
        // commenter's name and text). Put each of these videos in a list.
        Video video1 = new Video("2 HACKS to save $$ on HOME DECOR", "Caroline Winkler", 882);
        Comment comment1 = new Comment("lisahollingsworth2663", "Another day, another dollar.");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("nicolepsy", "Another shopping trick I use is to put stuff in my cart and leave it.  They will almost always offer a discount, sometimes within a day or two in order to get me to check out.");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("ClassyMi", "The first tip is especially crucial when booking flights and hotels! The price difference is just insane!");
        video1.AddComment(comment3);

        Video video2 = new Video("IKEA SHOPPING GUIDE // Tips for decorating on a budget, What to buy at IKEA hacks + tips", "Caroline Winkler", 1353);
        Comment comment4 = new Comment("10896tay", "I could not agree more that design and organization should be designed around a persons life not a instagram post! I love you and your videos!");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("holleyn739", "Thank you for your acknowledgment that not every design needs high end EVERYTHING.  Thanks Caroline for keeping it real.");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("pounepoune1", "“This is a shared error” haha you have the best one-liners, I swear!");
        video2.AddComment(comment6);

        Video video3 = new Video("Hacks to SCORE DEALS on Facebook Marketplace // thrifting secrets, antiques + decorating on a budget", "Caroline Winkler", 1490);
        Comment comment7 = new Comment("The1Destinator", "2025 here - hearing you say 'i hate teal' and knowing you painted your new library teal for a hot minute is making me giggle");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("Evajoyce_w", "Msgs really late or really early …it comes up at the top of the sellers feed. Also the couch tip is gold! I scored a $3k leather couch for $75 (excellent condition)");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("amandakesterson224", "Also, if you see something you really like from a seller, see what else they're selling. I've found the cutest things from the same seller and even told them to contact me if they come across more similar items.");
        video3.AddComment(comment9);
        
        // Then, have your program iterate through the list of videos and
        // for each one, display the title, author, length, number of
        // comments (from the method) and then list out all of the
        // comments for that video. Repeat this display for each video in
        // the list.
        video1.GetDisplayText();
        video2.GetDisplayText();
        video3.GetDisplayText();
    }
}