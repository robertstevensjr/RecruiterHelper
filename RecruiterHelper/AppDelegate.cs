using System.Collections.Generic;
using AppKit;
using Foundation;

namespace RecruiterHelper
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Let's load the interviewer list that we have saved in the cloud so that people can keep up
            // to date what's going on with their schedule
            List<Interviewer> interviewers = new List<Interviewer>
            {
                new Interviewer("Robert", "Stevens")
            };
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
