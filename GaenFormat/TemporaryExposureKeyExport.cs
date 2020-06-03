// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TemporaryExposureKeyExport.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.GeneratedGaenFormat
{
    #region Messages

    public sealed partial class TemporaryExposureKeyExport : pb::IMessage<TemporaryExposureKeyExport>
    {
        private static readonly pb::MessageParser<TemporaryExposureKeyExport> _parser =
            new pb::MessageParser<TemporaryExposureKeyExport>(() => new TemporaryExposureKeyExport());

        private pb::UnknownFieldSet _unknownFields;
        private int _hasBits0;

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<TemporaryExposureKeyExport> Parser
        {
            get { return _parser; }
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return TemporaryExposureKeyExportReflection.Descriptor.MessageTypes[0]; }
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TemporaryExposureKeyExport()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TemporaryExposureKeyExport(TemporaryExposureKeyExport other) : this()
        {
            _hasBits0 = other._hasBits0;
            startTimestamp_ = other.startTimestamp_;
            endTimestamp_ = other.endTimestamp_;
            region_ = other.region_;
            batchNum_ = other.batchNum_;
            batchSize_ = other.batchSize_;
            signatureInfos_ = other.signatureInfos_.Clone();
            keys_ = other.keys_.Clone();
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public TemporaryExposureKeyExport Clone()
        {
            return new TemporaryExposureKeyExport(this);
        }

        /// <summary>Field number for the "start_timestamp" field.</summary>
        public const int StartTimestampFieldNumber = 1;

        private readonly static ulong StartTimestampDefaultValue = 0UL;

        private ulong startTimestamp_;

        /// <summary>
        /// Time window of keys in this batch based on arrival to server, in UTC seconds
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong StartTimestamp
        {
            get
            {
                if ((_hasBits0 & 1) != 0)
                {
                    return startTimestamp_;
                }
                else
                {
                    return StartTimestampDefaultValue;
                }
            }
            set
            {
                _hasBits0 |= 1;
                startTimestamp_ = value;
            }
        }

        /// <summary>Gets whether the "start_timestamp" field is set</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasStartTimestamp
        {
            get { return (_hasBits0 & 1) != 0; }
        }

        /// <summary>Clears the value of the "start_timestamp" field</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearStartTimestamp()
        {
            _hasBits0 &= ~1;
        }

        /// <summary>Field number for the "end_timestamp" field.</summary>
        public const int EndTimestampFieldNumber = 2;

        private readonly static ulong EndTimestampDefaultValue = 0UL;

        private ulong endTimestamp_;

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong EndTimestamp
        {
            get
            {
                if ((_hasBits0 & 2) != 0)
                {
                    return endTimestamp_;
                }
                else
                {
                    return EndTimestampDefaultValue;
                }
            }
            set
            {
                _hasBits0 |= 2;
                endTimestamp_ = value;
            }
        }

        /// <summary>Gets whether the "end_timestamp" field is set</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasEndTimestamp
        {
            get { return (_hasBits0 & 2) != 0; }
        }

        /// <summary>Clears the value of the "end_timestamp" field</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearEndTimestamp()
        {
            _hasBits0 &= ~2;
        }

        /// <summary>Field number for the "region" field.</summary>
        public const int RegionFieldNumber = 3;

        private readonly static string RegionDefaultValue = "";

        private string region_;

        /// <summary>
        /// Region for which these keys came from (e.g., country)
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Region
        {
            get { return region_ ?? RegionDefaultValue; }
            set { region_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        /// <summary>Gets whether the "region" field is set</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasRegion
        {
            get { return region_ != null; }
        }

        /// <summary>Clears the value of the "region" field</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearRegion()
        {
            region_ = null;
        }

        /// <summary>Field number for the "batch_num" field.</summary>
        public const int BatchNumFieldNumber = 4;

        private readonly static int BatchNumDefaultValue = 0;

        private int batchNum_;

        /// <summary>
        /// E.g., File 2 in batch size of 10. Ordinal, 1-based numbering.
        /// Note: Not yet supported on iOS. Use values of 1 for both.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int BatchNum
        {
            get
            {
                if ((_hasBits0 & 4) != 0)
                {
                    return batchNum_;
                }
                else
                {
                    return BatchNumDefaultValue;
                }
            }
            set
            {
                _hasBits0 |= 4;
                batchNum_ = value;
            }
        }

        /// <summary>Gets whether the "batch_num" field is set</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasBatchNum
        {
            get { return (_hasBits0 & 4) != 0; }
        }

        /// <summary>Clears the value of the "batch_num" field</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearBatchNum()
        {
            _hasBits0 &= ~4;
        }

        /// <summary>Field number for the "batch_size" field.</summary>
        public const int BatchSizeFieldNumber = 5;

        private readonly static int BatchSizeDefaultValue = 0;

        private int batchSize_;

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int BatchSize
        {
            get
            {
                if ((_hasBits0 & 8) != 0)
                {
                    return batchSize_;
                }
                else
                {
                    return BatchSizeDefaultValue;
                }
            }
            set
            {
                _hasBits0 |= 8;
                batchSize_ = value;
            }
        }

        /// <summary>Gets whether the "batch_size" field is set</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool HasBatchSize
        {
            get { return (_hasBits0 & 8) != 0; }
        }

        /// <summary>Clears the value of the "batch_size" field</summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearBatchSize()
        {
            _hasBits0 &= ~8;
        }

        /// <summary>Field number for the "signature_infos" field.</summary>
        public const int SignatureInfosFieldNumber = 6;

        private static readonly pb::FieldCodec<SignatureInfo> _repeated_signatureInfos_codec
            = pb::FieldCodec.ForMessage(50, SignatureInfo.Parser);

        private readonly pbc::RepeatedField<SignatureInfo> signatureInfos_ =
            new pbc::RepeatedField<SignatureInfo>();

        /// <summary>
        /// Information about associated signatures
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<SignatureInfo> SignatureInfos
        {
            get { return signatureInfos_; }
        }

        /// <summary>Field number for the "keys" field.</summary>
        public const int KeysFieldNumber = 7;

        private static readonly pb::FieldCodec<TemporaryExposureKey> _repeated_keys_codec
            = pb::FieldCodec.ForMessage(58, TemporaryExposureKey.Parser);

        private readonly pbc::RepeatedField<TemporaryExposureKey> keys_ =
            new pbc::RepeatedField<TemporaryExposureKey>();

        /// <summary>
        /// The TemporaryExposureKeys themselves
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<TemporaryExposureKey> Keys
        {
            get { return keys_; }
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as TemporaryExposureKeyExport);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(TemporaryExposureKeyExport other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(other, this))
            {
                return true;
            }

            if (StartTimestamp != other.StartTimestamp) return false;
            if (EndTimestamp != other.EndTimestamp) return false;
            if (Region != other.Region) return false;
            if (BatchNum != other.BatchNum) return false;
            if (BatchSize != other.BatchSize) return false;
            if (!signatureInfos_.Equals(other.signatureInfos_)) return false;
            if (!keys_.Equals(other.keys_)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (HasStartTimestamp) hash ^= StartTimestamp.GetHashCode();
            if (HasEndTimestamp) hash ^= EndTimestamp.GetHashCode();
            if (HasRegion) hash ^= Region.GetHashCode();
            if (HasBatchNum) hash ^= BatchNum.GetHashCode();
            if (HasBatchSize) hash ^= BatchSize.GetHashCode();
            hash ^= signatureInfos_.GetHashCode();
            hash ^= keys_.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }

            return hash;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (HasStartTimestamp)
            {
                output.WriteRawTag(9);
                output.WriteFixed64(StartTimestamp);
            }

            if (HasEndTimestamp)
            {
                output.WriteRawTag(17);
                output.WriteFixed64(EndTimestamp);
            }

            if (HasRegion)
            {
                output.WriteRawTag(26);
                output.WriteString(Region);
            }

            if (HasBatchNum)
            {
                output.WriteRawTag(32);
                output.WriteInt32(BatchNum);
            }

            if (HasBatchSize)
            {
                output.WriteRawTag(40);
                output.WriteInt32(BatchSize);
            }

            signatureInfos_.WriteTo(output, _repeated_signatureInfos_codec);
            keys_.WriteTo(output, _repeated_keys_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (HasStartTimestamp)
            {
                size += 1 + 8;
            }

            if (HasEndTimestamp)
            {
                size += 1 + 8;
            }

            if (HasRegion)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
            }

            if (HasBatchNum)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BatchNum);
            }

            if (HasBatchSize)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(BatchSize);
            }

            size += signatureInfos_.CalculateSize(_repeated_signatureInfos_codec);
            size += keys_.CalculateSize(_repeated_keys_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }

            return size;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(TemporaryExposureKeyExport other)
        {
            if (other == null)
            {
                return;
            }

            if (other.HasStartTimestamp)
            {
                StartTimestamp = other.StartTimestamp;
            }

            if (other.HasEndTimestamp)
            {
                EndTimestamp = other.EndTimestamp;
            }

            if (other.HasRegion)
            {
                Region = other.Region;
            }

            if (other.HasBatchNum)
            {
                BatchNum = other.BatchNum;
            }

            if (other.HasBatchSize)
            {
                BatchSize = other.BatchSize;
            }

            signatureInfos_.Add(other.signatureInfos_);
            keys_.Add(other.keys_);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 9:
                    {
                        StartTimestamp = input.ReadFixed64();
                        break;
                    }
                    case 17:
                    {
                        EndTimestamp = input.ReadFixed64();
                        break;
                    }
                    case 26:
                    {
                        Region = input.ReadString();
                        break;
                    }
                    case 32:
                    {
                        BatchNum = input.ReadInt32();
                        break;
                    }
                    case 40:
                    {
                        BatchSize = input.ReadInt32();
                        break;
                    }
                    case 50:
                    {
                        signatureInfos_.AddEntriesFrom(input, _repeated_signatureInfos_codec);
                        break;
                    }
                    case 58:
                    {
                        keys_.AddEntriesFrom(input, _repeated_keys_codec);
                        break;
                    }
                }
            }
        }

    }
}

#endregion


#endregion Designer generated code