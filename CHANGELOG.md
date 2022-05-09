# Changelog

### [2.0.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v2.0.4...v2.0.5) (2022-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.0.0 to 2.1.0 ([ef70a1f](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/ef70a1ffb025bef9ff7a25bf9998ebbfcce6ceb4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.0.0 to 2.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.0.0...v2.1.0)

### [2.0.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v2.0.3...v2.0.4) (2022-05-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([b6d25c5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/b6d25c516279776f27e70bbcc7e04d1a9b3fbf74))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 2.0.3 to 2.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v2.0.3...v2.1.0)

### [2.0.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v2.0.2...v2.0.3) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([db21835](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/db21835ae12d7127f656fc9bb40b9875a313cc73))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 2.0.1 to 2.0.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v2.0.1...v2.0.3)

### [2.0.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v2.0.1...v2.0.2) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.1 to 2.0.0 ([6956f76](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/6956f76a858b0683a82c689be2199636e90c3c9a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.1 to 2.0.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.1...v2.0.0)

### [2.0.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v2.0.0...v2.0.1) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([5b5c1fc](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5b5c1fc3014d94857cf32d9163870354c5f1e444))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.8.6 to 2.0.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.8.6...v2.0.1)

## [2.0.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.5...v2.0.0) (2022-04-28)

#### :warning: BREAKING CHANGES :warning:

* **Malimbe:** This removes the last remaining elements of Malimbe and whilst it does not cause any breaking changes within this package, it removes Malimbe as a dependency which other projects that rely on this package may piggy back off this Malimbe dependency so it will break any project like that.

All of the previous functionality from Malimbe has been replicated in standard code without the need for it to be weaved by the Malimbe helper tags. ([9d53f2d](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9d53f2d37c848bb281e8741c7ec165fcbc352f11))

#### Features

* **Malimbe:** remove malimbe dependency ([9d53f2d](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9d53f2d37c848bb281e8741c7ec165fcbc352f11))

### [1.8.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.4...v1.8.5) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([0319c82](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/0319c8208c86f9108cc162711a8b959710798b80))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.8.4 to 1.8.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.8.4...v1.8.6)

### [1.8.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.3...v1.8.4) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.0 to 1.47.1 ([ddeb3e3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/ddeb3e375ec58c728c94c5b3b1586f5dea0f04cf))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.0 to 1.47.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.0...v1.47.1)

### [1.8.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.2...v1.8.3) (2022-03-15)

#### Miscellaneous Chores

* **dependabot:** remove bddckr from reviewers ([3d76df0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/3d76df05c49e0356e03356dbe1bcf120a4b7110d))
  > Chris hasn't been actively part of the project for a while.
* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([976635c](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/976635c23abedad8b9a67758ad46a2fa58d5bf8f))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.8.2 to 1.8.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.8.2...v1.8.4)

### [1.8.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.1...v1.8.2) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.46.0 to 1.47.0 ([136dd47](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/136dd47684cd0d3d0fabcac5b5ce730433b33ddc))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.46.0 to 1.47.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.46.0...v1.47.0)

### [1.8.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.8.0...v1.8.1) (2022-03-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([1e99e92](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1e99e9211bfd2d976e6017a446996d1a991b0129))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.32 to 1.8.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.32...v1.8.2)

## [1.8.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.32...v1.8.0) (2022-03-02)

#### Features

* **package.json:** add information urls to package ([c68b126](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c68b126a2b8e32e3fde259834e8fdfd539eee8d3))
  > The changelog, documentation and license url has been added to the package.json as these are used within the Unity package manager.

### [1.7.32](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.31...v1.7.32) (2022-02-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([45aedfe](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/45aedfef4579b9b67a94ba91e257378ff55ba8ab))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.30 to 1.7.32. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.30...v1.7.32)

### [1.7.31](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.30...v1.7.31) (2022-02-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.45.0 to 1.46.0 ([dc4f3e5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/dc4f3e51fa6b19dfa5b051158d5639ccca57e75e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.45.0 to 1.46.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.45.0...v1.46.0)

### [1.7.30](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.29...v1.7.30) (2022-02-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([d7c277e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/d7c277e7ae7a379f1a24687d8fbd78745ec84f4e))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.28 to 1.7.30. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.28...v1.7.30)

### [1.7.29](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.28...v1.7.29) (2022-02-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.44.0 to 1.45.0 ([9d795fb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9d795fb8800f1c3ed39b00b9210ae3502fd69c34))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.44.0 to 1.45.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.44.0...v1.45.0)

### [1.7.28](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.27...v1.7.28) (2022-01-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([1124037](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1124037809b856ddc42bef981cacdee14e19b7e3))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.26 to 1.7.28. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.26...v1.7.28)

### [1.7.27](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.26...v1.7.27) (2022-01-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.43.0 to 1.44.0 ([8f3890e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8f3890e48a4ceb9f801aab790a17dfa6ec2b1f70))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.43.0 to 1.44.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.43.0...v1.44.0)

### [1.7.26](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.25...v1.7.26) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([90d13ce](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/90d13ce8fd5a3ff3ee5c649dba24a8eb7c1326bb))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.24 to 1.7.26. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.24...v1.7.26)

### [1.7.25](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.24...v1.7.25) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.42.0 to 1.43.0 ([bfa8d2b](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/bfa8d2b50ad35c483b333d8b4fac2a1168e301db))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.42.0 to 1.43.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.42.0...v1.43.0)

### [1.7.24](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.23...v1.7.24) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([8dba222](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8dba2225538796e6b939f23473f2f5db15ed4630))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.22 to 1.7.24. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.22...v1.7.24)

### [1.7.23](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.22...v1.7.23) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.41.0 to 1.42.0 ([e77a890](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e77a8900a7a6334e75bf629c3cbc83a7a503c760))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.41.0 to 1.42.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.41.0...v1.42.0)

### [1.7.22](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.21...v1.7.22) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([6462535](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/64625357fa11b25d8b414bff850d93de21c60d90))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.20 to 1.7.22. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.20...v1.7.22)

### [1.7.21](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.20...v1.7.21) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.40.0 to 1.41.0 ([60dca4a](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/60dca4ad80f7deff55e7df9ac5fb2ac74b620d9f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.40.0 to 1.41.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.40.0...v1.41.0)

### [1.7.20](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.19...v1.7.20) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([e50e503](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e50e503b17fd2d8b07527633fe7dc7fb380213df))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.18 to 1.7.20. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.18...v1.7.20)

### [1.7.19](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.18...v1.7.19) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.39.0 to 1.40.0 ([712f293](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/712f2934c15d4727fa55ef2e7f4a237a61ceb6e8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.39.0 to 1.40.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.39.0...v1.40.0)

### [1.7.18](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.17...v1.7.18) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([9a7e454](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9a7e454a64ed53dd8e087c540a3ee81d6c220e3e))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.17 to 1.7.18. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.17...v1.7.18)

### [1.7.17](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.16...v1.7.17) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([da34eb0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/da34eb076b36c776598e012b051e792a45060d13))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.16 to 1.7.17. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.16...v1.7.17)

### [1.7.16](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.15...v1.7.16) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.1 to 1.39.0 ([40c815e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/40c815e1e4ac299ea40d4e903b6dfc322109a893))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.1 to 1.39.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.1...v1.39.0)

### [1.7.15](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.14...v1.7.15) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([e47bc10](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e47bc101f77495a7a3ef8ff5299c5cbbc8c691eb))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.14 to 1.7.16. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.14...v1.7.16)

### [1.7.14](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.13...v1.7.14) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.0 to 1.38.1 ([bbc220f](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/bbc220fe41c2be10efa808e14844fe1dd6fa11e5))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.0 to 1.38.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.0...v1.38.1)

### [1.7.13](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.12...v1.7.13) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([8acb12e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8acb12ef0e919544c135562b0a0c87b0a460cf90))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.12 to 1.7.14. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.12...v1.7.14)

### [1.7.12](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.11...v1.7.12) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.37.0 to 1.38.0 ([177b6cd](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/177b6cd6df721ec69355a24de987da7b7674c5e8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.37.0 to 1.38.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.37.0...v1.38.0)

### [1.7.11](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.10...v1.7.11) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([3d9f2ef](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/3d9f2ef664bc25890329092a4f62e29054439737))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.10 to 1.7.12. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.10...v1.7.12)

### [1.7.10](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.9...v1.7.10) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.2 to 1.37.0 ([362bcd8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/362bcd8c4b180d34f4ab782ced8d48908e22f776))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.2 to 1.37.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.2...v1.37.0)

### [1.7.9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.8...v1.7.9) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([3602a83](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/3602a83af1ed4d508a62a43eb1d167f9d8c21652))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.8 to 1.7.10. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.8...v1.7.10)

### [1.7.8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.7...v1.7.8) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.1 to 1.36.2 ([cc4d883](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/cc4d88323dd356859d8d0e6f75883e81222d9142))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.1 to 1.36.2. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.1...v1.36.2)

### [1.7.7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.6...v1.7.7) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([c84beb6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c84beb664fce28b0dc0a8b647d9d860133d88667))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.6 to 1.7.8. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.6...v1.7.8)

### [1.7.6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.5...v1.7.6) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.0 to 1.36.1 ([1c6d622](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1c6d622401796b688ac7f9cf2a0f58f126a455a3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.0 to 1.36.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.0...v1.36.1)

### [1.7.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.4...v1.7.5) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([1e0eade](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1e0eadecda67cebe52b6b10fc15714c068be2104))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.5 to 1.7.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.5...v1.7.6)
* **README.md:** update title logo to related-media repo ([aec12bb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/aec12bb42ccaba30b2ca2c8d800e5dcb15842a87))
  > The title logo is now located on the related-media repo.

### [1.7.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.3...v1.7.4) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([269afa7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/269afa77d41cfe61e2ff9388021bbfcd38207c55))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.3 to 1.7.5. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.3...v1.7.5)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.7.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.2...v1.7.3) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.35.0 to 1.36.0 ([e9167f3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e9167f3855f347d644aca1d18d900d22bfab2972))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.35.0 to 1.36.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.35.0...v1.36.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.7.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.1...v1.7.2) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([57d8da6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/57d8da6652856d508768d9a8091b43c796bc7516))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.7.1 to 1.7.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.7.1...v1.7.3)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.7.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.7.0...v1.7.1) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.34.1 to 1.35.0 ([7067788](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/7067788b7f9a786efac804c939c05f32662df681))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.34.1 to 1.35.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.34.1...v1.35.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

## [1.7.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.6.1...v1.7.0) (2021-04-15)

#### Features

* **Dispatcher:** add option for dispatcher to deselect all on null ([66b885f](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/66b885fe38dca38d035c889a259d0b1373706dce))
  > The Dispatcher can now optionally deselect all existing selected targets when a null target is passed to the Select method.

### [1.6.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.6.0...v1.6.1) (2021-04-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([9de6e28](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9de6e2821decaa1e30fb28e5c7876817cc2db301))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.13 to 1.7.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.13...v1.7.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

## [1.6.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.10...v1.6.0) (2021-04-07)

#### Features

* **Utility:** add prefab creator ([837981b](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/837981bbaac74413004563a5516443ba350e6d09))
  > The latest version of Zinnia has the basis of a prefab creator that can be used to enable easy adding of prefabs to a scene without needing to drag and drop from directories. Instead a new menu item is added for quickly adding prefabs. The guide has been updated to accommodate this and the FodyWeavers.xml is now located in the root to serve both the Runtime and Editor scripts.
* **Utility:** add prefab creator ([e3e6630](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e3e6630724dcd2108b77802be6a9806ee3223082))
  > The latest version of Zinnia has the basis of a prefab creator that can be used to enable easy adding of prefabs to a scene without needing to drag and drop from directories. Instead a new menu item is added for quickly adding prefabs. The guide has been updated to accommodate this and the FodyWeavers.xml is now located in the root to serve both the Runtime and Editor scripts.

#### Bug Fixes

* **package.json:** add missing reference to Editor directory ([65c7b42](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/65c7b42a3391ff2c2d56cd36017c5ce27141552d))
  > The build will fail without referencing this new Editor directory so it has now been added to the package.

### [1.5.10](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.9...v1.5.10) (2021-03-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([145d342](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/145d34281528d7a4e0543fbb85a66d6187df13f7))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.11 to 1.6.13. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.11...v1.6.13)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.8...v1.5.9) (2021-03-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.1 to 1.33.0 ([5b1c95c](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5b1c95ce7ba16839fcedb196a49f023fcf23e057))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.1 to 1.33.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.1...v1.33.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.7...v1.5.8) (2021-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([b1485a7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/b1485a7aad51101b6c4967571910af1847383013))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.9 to 1.6.11. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.9...v1.6.11)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.6...v1.5.7) (2021-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.0 to 1.31.1 ([701c6fd](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/701c6fd5e165d0d1bb7940ddee0e699fbac96ed6))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.0 to 1.31.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.0...v1.31.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.5...v1.5.6) (2021-02-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([4040b8d](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4040b8dbdb634f9874f1ef2caffde2cc0237dc30))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.7 to 1.6.9. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.7...v1.6.9)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.4...v1.5.5) (2021-02-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.30.0 to 1.31.0 ([8ad41fb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8ad41fb2e9c231a6468d10f73b2c913f137ae45c))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.30.0 to 1.31.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.30.0...v1.31.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.3...v1.5.4) (2021-02-06)

#### Bug Fixes

* **prefabs:** allow collision select after deselect occurs ([81dd845](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/81dd8453dd2a8bfc0ffb3a9765a6b17f05e38d52))
  > There was an issue where the collision select would not be available after the deselect was called because the select activation was only happening on the LastExited event, meaning select can only happen after everything stops hovering over it. But a deselect event should also allow select to occur again.

### [1.5.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.2...v1.5.3) (2021-02-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([263c8a0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/263c8a014f5c9f5f20e9d0c594b1681437f99ebb))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.5 to 1.6.7. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.5...v1.6.7)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.1...v1.5.2) (2021-02-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.29.0 to 1.30.0 ([745cbe9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/745cbe92d113a85ff9428edb03d2660af7194ddd))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.29.0 to 1.30.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.29.0...v1.30.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.5.0...v1.5.1) (2021-02-03)

#### Bug Fixes

* **API:** add missing autogenerated docs ([4aefd68](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4aefd68b935a33ffe97608cef8de43e395718d0b))
  > The autogenerated docs were not committed with the last change.

## [1.5.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.4.1...v1.5.0) (2021-02-03)

#### Features

* **prefabs:** allow object collisions to interact with target ([4adef43](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4adef4305b963511e4b65b40be0234bb01b4b882))
  > The Spatial Target can now be interacted with by colliding objects with it and the new optional hover collider allows for the hover state to be activated when the colliding object is near the target.
  > 
  > The new collision states are only activated if the collidable objects list is populated, otherwise it is ignored and the trigger collider is disabled.

### [1.4.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.4.0...v1.4.1) (2021-01-31)

#### Bug Fixes

* **API:** add missing api documentation ([4383a26](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4383a26d64236db1e2ab6b57f4bda1bc1e8d1a1f))
  > The docs for the SpatialTarget changes were not generated and have now been auto generated so they are up to date.

## [1.4.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.3.2...v1.4.0) (2021-01-31)

#### Features

* **SpatialTarget:** allow gameobject to be passed to enter,exit,select ([a1d3fcb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/a1d3fcb03c5d0b8af3b26b5507e5dc6aaec926eb))
  > The SpatialTarget can now accept a GameObject as the parameter for `Enter`, `Exit` and `Select` which will just make a basic SurfaceData object to be passed into the normal methods. This allows the potential for any object to trigger the spatial target states, such as an Interactor to touch the spatial target and still affect the states.

### [1.3.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.3.1...v1.3.2) (2021-01-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([8e805cb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8e805cb35796d0340970680b210c36507f57e981))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.3 to 1.6.5. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.3...v1.6.5)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.3.0...v1.3.1) (2021-01-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.1 to 1.29.0 ([c37824e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c37824e85ffc5750cba1811c043bb292ebf9e4c8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.1 to 1.29.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.1...v1.29.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.9...v1.3.0) (2020-12-22)

#### Features

* **SpatialTarget:** add option to delay the auto deselect on activate ([e3e19c0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e3e19c08bfa9a7b35e7491331c2a22db03cab6aa))
  > The DeselectSelf option can now be delayed by a given number of seconds by providing a value to the DeselectSelfDelay property on the Spatial Target Facade.

### [1.2.9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.8...v1.2.9) (2020-12-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([f0625bd](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/f0625bd17c09a58b66d32c9ae3f96f04a88d8f6b))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.2 to 1.6.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.2...v1.6.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.7...v1.2.8) (2020-12-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([eea4323](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/eea43236bdc4cf76635da0d0c46cdc7ce7f7df76))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.6.0 to 1.6.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.6.0...v1.6.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.6...v1.2.7) (2020-12-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.0 to 1.28.1 ([84f78ad](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/84f78ad22d123b831609c3965a4a6408ade6bedb))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.0 to 1.28.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.0...v1.28.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.5...v1.2.6) (2020-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([c4e6715](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c4e671562930e406f38c6e43eefb3d573cf7b3b1))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.11 to 1.6.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.11...v1.6.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.4...v1.2.5) (2020-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([24bc6d6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/24bc6d6b94ccc0a90e2a76e01d16f3e7d3f25cb1))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.9 to 1.5.11. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.9...v1.5.11)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.3...v1.2.4) (2020-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.27.0 to 1.28.0 ([5ff788a](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5ff788ad091fdc3a770a415ce6af6cfbbbfa508d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.27.0 to 1.28.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.27.0...v1.28.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.2...v1.2.3) (2020-12-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([f5b8055](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/f5b8055925b4ccfedc80eca28de12cfaf03664b6))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.7 to 1.5.9. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.7...v1.5.9)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.1...v1.2.2) (2020-12-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.1 to 1.27.0 ([f3b602d](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/f3b602dd763877667fb51f25d76d402d9c6bc19f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.1 to 1.27.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.1...v1.27.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.2.0...v1.2.1) (2020-12-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([63c7016](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/63c70164e297d987d3952fc0336d0ea4dde22bfb))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.6 to 1.5.7. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.6...v1.5.7)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.20...v1.2.0) (2020-12-07)

#### Features

* **Facade:** expose SpatialTarget Deselect method for easy access ([cfa6144](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/cfa614482000335ea03f3cc870c3d54cb2185a29))
  > There are occasions where being to deselect a SpatialTarget manually makes sense, but it can only be manually deselected from the internal SpatialTarget component. This exposes that internal method via the SpatialTargetFacade to make it easier to call.

### [1.1.20](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.19...v1.1.20) (2020-11-01)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([b386bf8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/b386bf81dd8cb038b4f5c0f92e7b7c9e3eb35ee8))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.4 to 1.5.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.4...v1.5.6)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.19](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.18...v1.1.19) (2020-11-01)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.0 to 1.25.1 ([50f6b35](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/50f6b35404dd01369a69bd6ea2e276b257ea3235))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.0 to 1.25.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.0...v1.25.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.18](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.17...v1.1.18) (2020-10-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([c72efda](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c72efda6321a67906cbfbf886c0f2fdfea7cfed8))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.2 to 1.5.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.2...v1.5.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.17](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.16...v1.1.17) (2020-10-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.24.0 to 1.25.0 ([d8fc768](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/d8fc768d7391138987fa3237908526b6c0cb634e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.24.0 to 1.25.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.24.0...v1.25.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.16](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.15...v1.1.16) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([c8251b4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c8251b4caa1580c79277ac29f57221087cf2c331))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.5.0 to 1.5.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.5.0...v1.5.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.15](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.14...v1.1.15) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.23.0 to 1.24.0 ([a30ef59](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/a30ef593f54865f139af97a4cbb1c93b5bf0664a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.23.0 to 1.24.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.23.0...v1.24.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.14](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.13...v1.1.14) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([997631e](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/997631e4048ff8f6effa285308bdde72bad31813))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.8 to 1.5.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.8...v1.5.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.13](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.12...v1.1.13) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([1512831](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1512831614e50ba4161c8416da636065c297bbec))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.6 to 1.4.8. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.6...v1.4.8)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.12](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.11...v1.1.12) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([4de1b8c](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4de1b8c0884dc98f87fe5728b10039f98b03e6d4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.11](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.10...v1.1.11) (2020-08-14)

#### Bug Fixes

* **Dispatcher:** remove double semi colon ([23b4e26](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/23b4e261461bc701eb41ef2c5e22abd26a3e9e99))
  > The end of line had a double semi colon which has now been removed.

### [1.1.10](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.9...v1.1.10) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([e5b86d4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/e5b86d450acaa32d84028151ca29610e534a7b2a))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.5 to 1.4.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.5...v1.4.6)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.8...v1.1.9) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.21.0 to 1.22.0 ([9ea4bc8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9ea4bc897e0da5a9830a6ce381ce962671a27674))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.21.0 to 1.22.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.21.0...v1.22.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.7...v1.1.8) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([5c98cdb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5c98cdb606740d7fbe09f6ec83acb3bef1e5fd77))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.3 to 1.4.5. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.3...v1.4.5)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.6...v1.1.7) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([74133cb](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/74133cb919f7e89a4b01142aa661b69d3c2f7e46))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.5...v1.1.6) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([aab209c](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/aab209c44ad6fea9b562f26ab8c1a75b87a2e2fe))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.2 to 1.4.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.2...v1.4.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.4...v1.1.5) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([5e9f804](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5e9f804a790a4f9d44884917523c6a61f8e5daab))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.4.0 to 1.4.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.4.0...v1.4.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.3...v1.1.4) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([3e7eda5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/3e7eda52503502edef69a1bc3b0791b3df30569e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.2...v1.1.3) (2020-07-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([705e1c4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/705e1c48aa087bea7e10109b506a34adecb1a994))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.3.1 to 1.4.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.3.1...v1.4.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.1...v1.1.2) (2020-07-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([8822bb9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8822bb9a44ae02130c9c6a6956e25f0ec9099d6f))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.3.0 to 1.3.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.3.0...v1.3.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.1.0...v1.1.1) (2020-07-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([22f17c4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/22f17c469bec23706376e7f5ed31b10072ebfe96))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.13 to 1.3.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.13...v1.3.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.13...v1.1.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([a8e3372](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/a8e3372998800e03517ed81bf56bff8aebb8d0f4))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([43657da](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/43657da26c4f7ff4043b3238bd487002c214a76a))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.0.13](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.12...v1.0.13) (2020-06-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([981e80a](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/981e80aae5dd1944d57dde471ed4b5155bdcc2e6))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.12 to 1.2.13. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.12...v1.2.13)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.12](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.11...v1.0.12) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([5b3103b](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5b3103beacca63ac6e0087dbaa2e83d6933e3c71))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.10 to 1.2.12. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.10...v1.2.12)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.11](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.10...v1.0.11) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([1e33a21](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/1e33a210066b8abb779e7adcf0a5cc1c7beeae6f))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.10 to 1.2.11. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.10...v1.2.11)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.10](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.9...v1.0.10) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([b69e1fa](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/b69e1fad02238c8596306378670cf58a7b791d18))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.9](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.8...v1.0.9) (2020-06-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([b998f0d](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/b998f0d7e3ae33401c8620d02e8645ae5ebef1c9))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.9 to 1.2.10. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.9...v1.2.10)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.8](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.7...v1.0.8) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([37e54bf](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/37e54bfc6a259ad889411d2fdbeaf874e8e322ee))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.7 to 1.2.9. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.7...v1.2.9)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.7](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.6...v1.0.7) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([fff4056](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/fff4056a7a1b7c95525667ef9f9edf5bab58dfff))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.5...v1.0.6) (2020-05-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([9b0e8b4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/9b0e8b4e0b72684bfb8288615079ee2597ec60f3))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.6 to 1.2.7. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.6...v1.2.7)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.4...v1.0.5) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([9523229](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/95232299bf3f51e6dc545bb7738fcc1ce67b2e18))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.4 to 1.2.6. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.4...v1.2.6)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.3...v1.0.4) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([5558ada](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/5558adaafa09a27e5a5d0ec64cb2febd100d90b0))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.2...v1.0.3) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.indicators.objectpointers.unity ([8108b12](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/8108b1216eb157c88241492e41ef02ce83305ed6))
  > Bumps [io.extendreality.tilia.indicators.objectpointers.unity](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity) from 1.2.2 to 1.2.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity/compare/v1.2.2...v1.2.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.1...v1.0.2) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([7102450](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/71024501c213a349c120fba10ca7728c28b6d6c5))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/compare/v1.0.0...v1.0.1) (2020-05-17)

#### Bug Fixes

* **HowToGuides:** provide correct link for version release badge ([c534452](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/c5344521bc01f148ac939b86266fef8ca1aace50))
  > The Version-Release badge link was incorrect and pointing to the wrong repo. This has now been updated.

## 1.0.0 (2020-05-16)

#### Features

* **structure:** create initial prefab and user guides ([4493cf1](https://github.com/ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity/commit/4493cf184d222618e9843be805c532f45867b7e6))
  > The structure of the repository has been created with all the required files for the package, the prefab and the installation guide.
