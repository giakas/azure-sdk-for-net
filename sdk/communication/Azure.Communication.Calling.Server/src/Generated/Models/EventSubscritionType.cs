// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.Calling.Server
{
    /// <summary> The EventSubscritionType. </summary>
    public readonly partial struct EventSubscritionType : IEquatable<EventSubscritionType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EventSubscritionType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventSubscritionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ParticipantsUpdatedValue = "participantsUpdated";
        private const string DtmfReceivedValue = "dtmfReceived";

        /// <summary> participantsUpdated. </summary>
        public static EventSubscritionType ParticipantsUpdated { get; } = new EventSubscritionType(ParticipantsUpdatedValue);
        /// <summary> dtmfReceived. </summary>
        public static EventSubscritionType DtmfReceived { get; } = new EventSubscritionType(DtmfReceivedValue);
        /// <summary> Determines if two <see cref="EventSubscritionType"/> values are the same. </summary>
        public static bool operator ==(EventSubscritionType left, EventSubscritionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventSubscritionType"/> values are not the same. </summary>
        public static bool operator !=(EventSubscritionType left, EventSubscritionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventSubscritionType"/>. </summary>
        public static implicit operator EventSubscritionType(string value) => new EventSubscritionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventSubscritionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventSubscritionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
