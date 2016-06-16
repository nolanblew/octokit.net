﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Pull Requests API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/activity/notifications/">Pull Requests API documentation</a> for more information.
    /// </remarks>
    public interface IPullRequestsClient
    {
        /// <summary>
        /// Client for managing comments.
        /// </summary>
        IPullRequestReviewCommentsClient Comment { get; }

        /// <summary>
        /// Get a pull request by number.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#get-a-single-pull-request
        /// </remarks>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        Task<PullRequest> Get(string owner, string name, int number);

        /// <summary>
        /// Get a pull request by number.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#get-a-single-pull-request
        /// </remarks>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        Task<PullRequest> Get(int repositoryId, int number);

        /// <summary>
        /// Get all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(string owner, string name);

        /// <summary>
        /// Get all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(int repositoryId);

        /// <summary>
        /// Get all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(string owner, string name, ApiOptions options);

        /// <summary>
        /// Get all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(int repositoryId, ApiOptions options);

        /// <summary>
        /// Query pull requests for the repository based on criteria
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="request">Used to filter and sort the list of pull requests returned</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(string owner, string name, PullRequestRequest request);

        /// <summary>
        /// Query pull requests for the repository based on criteria
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="request">Used to filter and sort the list of pull requests returned</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(int repositoryId, PullRequestRequest request);

        /// <summary>
        /// Query pull requests for the repository based on criteria
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="request">Used to filter and sort the list of pull requests returned</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(string owner, string name, PullRequestRequest request, ApiOptions options);

        /// <summary>
        /// Query pull requests for the repository based on criteria
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="request">Used to filter and sort the list of pull requests returned</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAllForRepository(int repositoryId, PullRequestRequest request, ApiOptions options);

        /// <summary>
        /// Create a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#create-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newPullRequest">A <see cref="NewPullRequest"/> instance describing the new PullRequest to create</param>
        /// <returns></returns>
        Task<PullRequest> Create(string owner, string name, NewPullRequest newPullRequest);

        /// <summary>
        /// Create a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#create-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="newPullRequest">A <see cref="NewPullRequest"/> instance describing the new PullRequest to create</param>
        /// <returns></returns>
        Task<PullRequest> Create(int repositoryId, NewPullRequest newPullRequest);

        /// <summary>
        /// Create a pull request for the specified repository. 
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#update-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The PullRequest number</param>
        /// <param name="pullRequestUpdate">An <see cref="PullRequestUpdate"/> instance describing the changes to make to the PullRequest
        /// </param>
        /// <returns></returns>
        Task<PullRequest> Update(string owner, string name, int number, PullRequestUpdate pullRequestUpdate);

        /// <summary>
        /// Create a pull request for the specified repository. 
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#update-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The PullRequest number</param>
        /// <param name="pullRequestUpdate">An <see cref="PullRequestUpdate"/> instance describing the changes to make to the PullRequest
        /// </param>
        /// <returns></returns>
        Task<PullRequest> Update(int repositoryId, int number, PullRequestUpdate pullRequestUpdate);

        /// <summary>
        /// Merge a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#merge-a-pull-request-merge-buttontrade</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <param name="mergePullRequest">A <see cref="MergePullRequest"/> instance describing a pull request merge</param>
        /// <returns></returns>
        Task<PullRequestMerge> Merge(string owner, string name, int number, MergePullRequest mergePullRequest);

        /// <summary>
        /// Merge a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#merge-a-pull-request-merge-buttontrade</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <param name="mergePullRequest">A <see cref="MergePullRequest"/> instance describing a pull request merge</param>
        /// <returns></returns>
        Task<PullRequestMerge> Merge(int repositoryId, int number, MergePullRequest mergePullRequest);

        /// <summary>
        /// Get the pull request merge status.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#get-if-a-pull-request-has-been-merged</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<bool> Merged(string owner, string name, int number);

        /// <summary>
        /// Get the pull request merge status.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#get-if-a-pull-request-has-been-merged</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<bool> Merged(int repositoryId, int number);

        /// <summary>
        /// Get the list of commits on a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#list-commits-on-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequestCommit>> Commits(string owner, string name, int number);

        /// <summary>
        /// Get the list of commits on a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#list-commits-on-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequestCommit>> Commits(int repositoryId, int number);

        /// <summary>
        /// Get the list of files on a pull request.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/pulls/#list-pull-requests-files</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequestFile>> Files(string owner, string name, int number);

        /// <summary>
        /// Get the list of files on a pull request.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/pulls/#list-pull-requests-files</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequestFile>> Files(int repositoryId, int number);
    }
}
