using System.Drawing;
using Line.Messaging;
using Line.Messaging.Webhooks;

public class LineService : ILineService
{
    public LineService()
    {
    }

    public async Task<List<ISendMessage>> ProcessTextEventMessageAsync(string channelId, string userId, string message)
    {
        var result = null as List<ISendMessage>;
        if (message.Contains("新造的人"))
        {
            result = new List<ISendMessage>
            {
            new TextMessage("https://youtu.be/VjF_mjBVK6c?si=4LCsQNonAUYsMh-S")
            };
            return result;
        }
        if (message.Contains("Someone You Loved"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/SxJmz6b5d18?si=AcSpsyynRAQOaHeU")
            };
            return result;
        }
        if (message.Contains("Push"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/MV045tu4tN0?si=TYylzMqf9PMfkTQ2")
            };
            return result;
        }
        if (message.Contains("挪威的森林"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/IMJxnPP883Y?si=QzU4COeJo_3kmA73")
            };
            return result;
        }
        if (message.Contains("LIVE FOR YOU"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/NTrkNUziJdI?si=FZHBbJLdE79Iq6D8")
            };
            return result;
        }
        if (message.Contains("如果可以"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/Z7_hI1AxEKg?si=dlWrdg-miBKiCmgt")
            };
            return result;
        }
        if (message.Contains("Champion"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/eNWTBimUDuk?si=2o5aOeclYmAIgPW1")
            };
            return result;
        }
        if (message.Contains("Just Me"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/exbZfNR10Ak?si=bh4xv79eYduF53E7")
            };
            return result;
        }
        if (message.Contains("Sunflower"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/x_7Rz2tB6ac?si=Wbp5Rk3nm5bD3W7m")
            };
            return result;
        }
        if (message.Contains("Sextasy"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/IRYliuNMO7c?si=0KnIejhMsM5MJSpS")
            };
            return result;
        }
        if (message.Contains("Stay"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/cTl6Mq8vErk?si=9iQ6ekCJsBhFebm2")
            };
            return result;
        }
        if (message.Contains("Light Switch"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/D5uB048uBa0?si=FImgD70Gk8Jqh_SC")
            };
            return result;
        }
        if (message.Contains("My City"))
        {
            result = new List<ISendMessage>
            {
                new TextMessage("https://youtu.be/GOC2YjU0Nyk?si=Dxqo1-PtPqy7My9N")
            };
            return result;
        }
        result = new List<ISendMessage>
        {
            new TextMessage("你是講啥小?\n是在靠北喔?"),
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessStickerEventMessageAsync(string channelId, string userId,string packageId, string stickerId)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a sticker event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId,string originalContentUrl,
        string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessImageEventMessageAsync(string channelId, string userId, Image image)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a image event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessVideoEventMessageAsync(string channelId, string userId,string originalContentUrl, string previewImageUrl)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a video event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessAudioEventMessageAsync(string channelId, string userId,string originalContentUrl, int duration)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a audio event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }

    public async Task<List<ISendMessage>> ProcessLocationEventMessageAsync(string channelId, string userId,string title, string address, float latitude, float longitude)
    {
        var result = null as List<ISendMessage>;

        result = new List<ISendMessage>
        {
            new TextMessage($"Receive a location event message \nchannelId={channelId}  \nuserId={userId}")
        };
        return result;
    }
}