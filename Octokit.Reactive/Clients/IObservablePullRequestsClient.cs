﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Octokit.Reactive
{
    /// <summary>
    /// A client for GitHub's Pull Requests API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/activity/notifications/">Pull Requests API documentation</a> for more information.
    /// </remarks>
    public interface IObservablePullRequestsClient
    {
        /// <summary>
        /// Client for managing comments.
        /// </summary>
        IObservablePullRequestReviewCommentsClient Comment { get; }

        /// <summary>
        /// Gets a single Pull Request by number.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#get-a-single-pull-request
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The number of the pull request</param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<PullRequest> Get(string owner, string name, int number);

        /// <summary>
        /// Gets a single Pull Request by number.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#get-a-single-pull-request
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The number of the pull request</param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<PullRequest> Get(int repositoryId, int number);

        /// <summary>
        /// Gets all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns></returns>
        IObservable<PullRequest> GetAllForRepository(string owner, string name);

        /// <summary>
        /// Gets all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <returns></returns>
        IObservable<PullRequest> GetAllForRepository(int repositoryId);

        /// <summary>
        /// Gets all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        IObservable<PullRequest> GetAllForRepository(string owner, string name, ApiOptions options);

        /// <summary>
        /// Gets all open pull requests for the repository.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="options">Options for changing the API response</param>
        /// <returns></returns>
        IObservable<PullRequest> GetAllForRepository(int repositoryId, ApiOptions options);

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
        IObservable<PullRequest> GetAllForRepository(string owner, string name, PullRequestRequest request);

        /// <summary>
        /// Query pull requests for the repository based on criteria
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="request">Used to filter and sort the list of pull requests returned</param>
        /// <returns></returns>
        IObservable<PullRequest> GetAllForRepository(int repositoryId, PullRequestRequest request);

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
        IObservable<PullRequest> GetAllForRepository(string owner, string name, PullRequestRequest request, ApiOptions options);

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
        IObservable<PullRequest> GetAllForRepository(int repositoryId, PullRequestRequest request, ApiOptions options);

        /// <summary>
        /// Creates a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#create-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="newPullRequest">A <see cref="NewPullRequest"/> instance describing the new PullRequest to create</param>
        /// <returns></returns>
        IObservable<PullRequest> Create(string owner, string name, NewPullRequest newPullRequest);

        /// <summary>
        /// Creates a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#create-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="newPullRequest">A <see cref="NewPullRequest"/> instance describing the new PullRequest to create</param>
        /// <returns></returns>
        IObservable<PullRequest> Create(int repositoryId, NewPullRequest newPullRequest);

        /// <summary>
        /// Update a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#update-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The PullRequest number</param>
        /// <param name="pullRequestUpdate">An <see cref="PullRequestUpdate"/> instance describing the changes to make to the PullRequest
        /// </param>
        /// <returns></returns>
        IObservable<PullRequest> Update(string owner, string name, int number, PullRequestUpdate pullRequestUpdate);

        /// <summary>
        /// Update a pull request for the specified repository.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#update-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The PullRequest number</param>
        /// <param name="pullRequestUpdate">An <see cref="PullRequestUpdate"/> instance describing the changes to make to the PullRequest
        /// </param>
        /// <returns></returns>
        IObservable<PullRequest> Update(int repositoryId, int number, PullRequestUpdate pullRequestUpdate);

        /// <summary>
        /// Merge a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#merge-a-pull-request-merge-buttontrade</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <param name="mergePullRequest">A <see cref="MergePullRequest"/> instance describing a pull request merge</param>
        /// <returns></returns>
        IObservable<PullRequestMerge> Merge(string owner, string name, int number, MergePullRequest mergePullRequest);

        /// <summary>
        /// Merge a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#merge-a-pull-request-merge-buttontrade</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <param name="mergePullRequest">A <see cref="MergePullRequest"/> instance describing a pull request merge</param>
        /// <returns></returns>
        IObservable<PullRequestMerge> Merge(int repositoryId, int number, MergePullRequest mergePullRequest);

        /// <summary>
        /// Gets the pull request merge status.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#get-if-a-pull-request-has-been-merged</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<bool> Merged(string owner, string name, int number);

        /// <summary>
        /// Gets the pull request merge status.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#get-if-a-pull-request-has-been-merged</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<bool> Merged(int repositoryId, int number);

        /// <summary>
        /// Gets the list of commits on a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#list-commits-on-a-pull-request</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<PullRequestCommit> Commits(string owner, string name, int number);

        /// <summary>
        /// Gets the list of commits on a pull request.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/pulls/#list-commits-on-a-pull-request</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<PullRequestCommit> Commits(int repositoryId, int number);

        /// <summary>
        /// Get the list of files on a pull request.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/pulls/#list-pull-requests-files</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<PullRequestFile> Files(string owner, string name, int number);

        /// <summary>
        /// Get the list of files on a pull request.
        /// </summary>
        /// <remarks>https://developer.github.com/v3/pulls/#list-pull-requests-files</remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        IObservable<PullRequestFile> Files(int repositoryId, int number);
    }
}
