using MailKit;
using System;
using System.Threading;

namespace E_mail_client
{
    class TransferProgress : ITransferProgress
    {
        private long _bytesTransferred;
        private long _totalSize;

        public event EventHandler<int> ProgressChanged;

        public int Percents
        {
            get { return (int)(_bytesTransferred / _totalSize * 100); }
        }

        void ITransferProgress.Report(long bytesTransferred, long totalSize)
        {
            _bytesTransferred = bytesTransferred;
            _totalSize = totalSize;
            OnProgressChanged();
        }

        void ITransferProgress.Report(long bytesTransferred)
        {
            throw new NotSupportedException();
        }

        protected virtual void OnProgressChanged()
        {
            Volatile.Read(ref ProgressChanged)?.BeginInvoke(this, Percents, null, null);
        }
    }
}
