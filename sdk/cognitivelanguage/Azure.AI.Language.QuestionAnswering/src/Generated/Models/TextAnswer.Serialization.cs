// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class TextAnswer
    {
        internal static TextAnswer DeserializeTextAnswer(JsonElement element)
        {
            Optional<string> answer = default;
            Optional<double> confidenceScore = default;
            Optional<string> id = default;
            Optional<AnswerSpan> answerSpan = default;
            Optional<int> offset = default;
            Optional<int> length = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answer"u8))
                {
                    answer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("answerSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    answerSpan = AnswerSpan.DeserializeAnswerSpan(property.Value);
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    length = property.Value.GetInt32();
                    continue;
                }
            }
            return new TextAnswer(answer.Value, Optional.ToNullable(confidenceScore), id.Value, answerSpan.Value, Optional.ToNullable(offset), Optional.ToNullable(length));
        }
    }
}
