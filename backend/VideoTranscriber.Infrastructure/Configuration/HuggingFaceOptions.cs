namespace VideoTranscriber.Infrastructure.Configuration;

public sealed class HuggingFaceOptions
{
    public const string SectionName = "HuggingFace";

    public string BaseUrl { get; init; } = "https://api-inference.huggingface.co";

    public string Model { get; init; } = "openai/whisper-large-v3";

    public string AccessToken { get; init; } = string.Empty;
}
