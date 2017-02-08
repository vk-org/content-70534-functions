using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request.");

    var words = new List<string> {
        "sun","wool","learned","trick","needle","rejoice","assorted","piquant","touch","tall","move","unadvised","humor","dry","neat","unlock","interesting","waste","destroy","fall","suffer","untidy","harbor","rule","stereotyped","wander","maddening","nose","painful","brush","scattered","twist","branch","sack","slope","wall","support","earthquake","act","enchanting","trade","hop","shirt","brake","guard","excellent","meaty","oval","lonely","children","weak","rely","stone","familiar","activity","rat","mix","insurance","texture","wreck","scent","rhetorical","scribble","marvelous","somber","trot","stroke","explode","watch","ignore","stir","undesirable","men","uneven","spray","chin","look","verse","irritating","crate","train","jazzy","wrap","matter","dog","dress","ball","trail","party","mom","record","scarce","illegal","shake","produce","thaw","separate","reply","remember","yell","multiply","minor","witty","attraction","error","curve","mouth","payment","lake","girl","writer","oafish","creepy","necessary","cat","trip","prepare","ice","drawer","cannon","year","drown","elated","friction","hand","educated","credit","repulsive","snail","victorious","notebook","royal","sturdy","reaction","form","muddled","playground","bell","wipe","hands","hallowed","caption","calculator","insect","greet","animated","adorable","handsome","eyes","representative","shaky","fair","voiceless","growth","field","ripe","shock","worm","sniff","succinct","number","broad","hydrant","permit","bathe","authority"
    };

    var rand = new Random();
    var index = rand.Next(165);

    var res = req.CreateResponse(HttpStatusCode.OK);
    res.Content = new StringContent(words[index], System.Text.Encoding.UTF8, "text/plain");

    return res;
}