using System;
using System.Collections.Generic;
using System.Text;

namespace CallMessageDemo.Interface
{
    public interface ISinchService
    {
        void StartSinchClient(string username);
        void StopSinchClient();
        bool IsSinchClientStarted();

        void SendMessage(string receipient, string message);
        void CallVoice(string receipientId);
        void CallVideo(string receipientId);

        void MessageDetails();
    }
}
